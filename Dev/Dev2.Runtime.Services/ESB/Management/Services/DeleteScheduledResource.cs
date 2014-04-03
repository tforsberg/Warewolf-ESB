﻿using System.Collections.Generic;
using System.Text;
using Dev2.Common;
using Dev2.Communication;
using Dev2.DynamicServices;
using Dev2.DynamicServices.Objects;
using Dev2.Runtime.Security;
using Dev2.Scheduler;
using Dev2.Scheduler.Interfaces;
using Dev2.Workspaces;

namespace Dev2.Runtime.ESB.Management.Services
{
    public class DeleteScheduledResource : IEsbManagementEndpoint
    {
        private IServerSchedulerFactory _schedulerFactory;
        ISecurityWrapper _securityWrapper;
        public string HandlesType()
        {
            return "DeleteScheduledResourceService";
        }

        public StringBuilder Execute(Dictionary<string, StringBuilder> values, IWorkspace theWorkspace)
        {
            var result = new ExecuteMessage { HasError = false };
            StringBuilder tmp;
            values.TryGetValue("Resource", out tmp);
            var serializer = new Dev2JsonSerializer();

            if (tmp != null)
            {
                var res = serializer.Deserialize<IScheduledResource>(tmp);

                using(var model = SchedulerFactory.CreateModel(GlobalConstants.SchedulerFolderId, SecurityWrapper))
                {
                    model.DeleteSchedule(res);
                }
            }
            else
            {
                result.Message.Append("No Resource Selected");
                result.HasError = true;
            }
            return serializer.SerializeToBuilder(result);
        }



        public DynamicService CreateServiceEntry()
        {
            var deleteScheduledResource = new DynamicService
            {
                Name = HandlesType(),
                DataListSpecification =
                    "<DataList><Dev2System.ManagmentServicePayload ColumnIODirection=\"Both\"></Dev2System.ManagmentServicePayload></DataList>"
            };

            var deleteScheduledResourceAction = new ServiceAction
            {
                Name = HandlesType(),
                ActionType = enActionType.InvokeManagementDynamicService,
                SourceMethod = HandlesType()
            };


            deleteScheduledResource.Actions.Add(deleteScheduledResourceAction);

            return deleteScheduledResource;
        }

        public IServerSchedulerFactory SchedulerFactory
        {
            get { return _schedulerFactory ?? new ServerSchedulerFactory(); }
            set { _schedulerFactory = value; }
        }
        public ISecurityWrapper SecurityWrapper
        {
            get
            {
                return _securityWrapper ?? new SecurityWrapper(ServerAuthorizationService.Instance);
            }
            set
            {
                _securityWrapper = value;
            }
        }
    }
}
