﻿using System;
using System.Collections.Generic;
using Caliburn.Micro;
using Dev2.Common.Utils;
using Dev2.Communication;
using Dev2.Services.Events;
using Dev2.Studio.Core;
using Dev2.Studio.Core.Interfaces;
using Dev2.Studio.Core.Messages;
using Dev2.Webs.Callbacks;

// ReSharper disable once CheckNamespace

namespace Dev2.Studio.Webs.Callbacks
{
    public class FileChooserCallbackHandler : WebsiteCallbackHandler
    {
        readonly FileChooserMessage _fileChooserMessage;

        public FileChooserCallbackHandler(FileChooserMessage fileChooserMessage)
            : this(fileChooserMessage, EventPublishers.Aggregator, EnvironmentRepository.Instance)
        {
        }

        public FileChooserCallbackHandler(FileChooserMessage fileChooserMessage, IEventAggregator eventPublisher, IEnvironmentRepository currentEnvironmentRepository)
            : base(eventPublisher, currentEnvironmentRepository)
        {
            _fileChooserMessage = fileChooserMessage;
            VerifyArgument.IsNotNull("fileChooserMessage", fileChooserMessage);
        }

        public override void Save(string value, bool closeBrowserWindow = true)
        {
            if(string.IsNullOrEmpty(value))
            {
                _fileChooserMessage.SelectedFiles = null;
            }
            else
            {
                var scrubbedValue = JSONUtils.ScrubJSON(value).Replace(@"\\", @"\");

                var result = new Dev2JsonSerializer().Deserialize<FileChooserResult>(scrubbedValue);
                _fileChooserMessage.SelectedFiles = result.FilePaths;
            }
            if(closeBrowserWindow)
            {
                Close();
            }
        }

        public override void Save(string value, IEnvironmentModel environmentModel, bool closeBrowserWindow = true)
        {
            throw new NotImplementedException();
        }

        protected override void Save(IEnvironmentModel environmentModel, dynamic jsonObj)
        {
            throw new NotImplementedException();
        }

        public class FileChooserResult
        {
            public IEnumerable<string> FilePaths { get; set; }
        }
    }

}
