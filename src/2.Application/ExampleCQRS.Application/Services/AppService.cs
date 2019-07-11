namespace ExampleCQRS.Application.Services
{
    using System.Collections.Generic;
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Domain.Interfaces;

    public abstract class AppService : IAppService
    {
        private readonly IErrorNotificationHandler errorNotificationHandler;

        public AppService(IErrorNotificationHandler errorNotificationHandler)
        {
            this.errorNotificationHandler = errorNotificationHandler;
        }

        public bool IsValidOperation()
        {
            return (!errorNotificationHandler.HasNotifications());
        }

        public IEnumerable<object> GetErrors()
        {
            //TODO: Implement Adapter pattern to tranform ErrorNotification from Domain to type for Presentation

            return errorNotificationHandler.GetNotifications();
        }

    }
}