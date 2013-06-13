﻿using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using Dev2.Common;

namespace Dev2.Diagnostics
{
    public class DebugDispatcher : IDebugDispatcher
    {
        // The Guid is the workspace ID of the writer
        private readonly ConcurrentDictionary<Guid, IDebugWriter> _writers = new ConcurrentDictionary<Guid, IDebugWriter>();
        private static ConcurrentQueue<IDebugState> _writerQueue = new ConcurrentQueue<IDebugState>();
        private static Thread _writerThread = new Thread(WriteLoop);
        private static ManualResetEventSlim _writeWaithandle = new ManualResetEventSlim(false);
        private static object _waitHandleGuard = new object();
        private static bool _shutdownRequested;

        #region Singleton Instance

        static DebugDispatcher _instance;
        public static DebugDispatcher Instance
        {
            get
            {
                return _instance ?? (_instance = new DebugDispatcher());
            }
        }

        #endregion

        #region Initialization

        static DebugDispatcher()
        {
            _writerThread.Start();
        }

        // Prevent instantiation
        DebugDispatcher()
        {

        }

        #endregion

        #region Properties

        #region Count

        /// <summary>
        /// Gets the number of writers.
        /// </summary>
        public int Count
        {
            get
            {
                return _writers.Count;
            }
        }

        #endregion

        #endregion

        #region Add

        /// <summary>
        /// Adds the specified writer to the dispatcher.
        /// </summary>
        /// <param name="workspaceID">The ID of the workspace to which the writer belongs.</param>
        /// <param name="writer">The writer to be added.</param>
        public void Add(Guid workspaceID, IDebugWriter writer)
        {
            if (writer == null || _shutdownRequested)
            {
                return;
            }
            _writers.TryAdd(workspaceID, writer);
        }

        #endregion

        #region Remove

        /// <summary>
        /// Removes the specified workspace from the dispatcher.
        /// </summary>
        /// <param name="workspaceID">The ID of workspace to be removed.</param>
        public void Remove(Guid workspaceID)
        {
            IDebugWriter writer;
            _writers.TryRemove(workspaceID, out writer);
        }

        #endregion

        #region Get

        /// <summary>
        /// Gets the writer for the given workspace ID.
        /// </summary>
        /// <param name="workspaceID">The workspace ID to be queried.</param>
        /// <returns>The <see cref="IDebugWriter"/> with the specified ID, or <code>null</code> if not found.</returns>
        public IDebugWriter Get(Guid workspaceID)
        {
            IDebugWriter writer;
            _writers.TryGetValue(workspaceID, out writer);
            return writer;
        }

        #endregion

        #region Shutdown

        public void Shutdown()
        {
            _shutdownRequested = true;
            lock (_waitHandleGuard)
            {
                IDebugState debugState;
                while (_writerQueue.Count > 0)
                {
                    _writerQueue.TryDequeue(out debugState);
                }
                _writeWaithandle.Set();
            }
        }

        #endregion Shutdown

        #region Write

        /// <summary>
        /// Writes the given state to the <see cref="IDebugWriter" /> registered for the given workspace.
        /// <remarks>
        /// This must implement the one-way (fire and forget) message exchange pattern.
        /// </remarks>
        /// </summary>
        /// <param name="debugState">The state to be written.</param>
        /// <returns>The task that was created.</returns>
        public Task Write(IDebugState debugState)
        {
            if (debugState == null)
            {
                return null;
            }

            //return Task.Factory.StartNew(() => debugState.Write(writer));

            lock (_waitHandleGuard)
            {
                _writerQueue.Enqueue(debugState);
                _writeWaithandle.Set();
            }

            var t = new Task(() => { });
            t.Start();
            return t;
        }

        #endregion

        #region WriteLoop

        private static void WriteLoop()
        {
            while (true)
            {
                _writeWaithandle.Wait();

                if (_shutdownRequested)
                {
                    return;
                }

                IDebugState debugState;
                if (_writerQueue.TryDequeue(out debugState))
                {
                    IDebugWriter writer;

                    // TODO : Fix check so 

                    if (debugState != null && (writer = Instance.Get(debugState.WorkspaceID)) != null)
                    {
                        debugState.Write(writer);
                    }
                }

                ServerLogger.LogDebug(debugState);

                lock (_waitHandleGuard)
                {
                    if (_writerQueue.Count == 0)
                    {
                        _writeWaithandle.Reset();
                    }
                }
            }
        }

        #endregion WriteLoop
    }
}
