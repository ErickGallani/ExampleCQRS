namespace ExampleCQRS.Application.Services
{
    using System.Linq;
    using ExampleCQRS.Application.Enums;
    using ExampleCQRS.Application.Errors;
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Domain.Interfaces;

    public abstract class AppService : IAppService
    {
        private readonly IErrorNotificationHandler errorNotificationHandler;

        protected ServiceResponse GetResponse() 
        {
            if(IsValidOperation())
            {
                return new ServiceResponse(ServiceResponseStatus.Success, null);
            }

            var errors =
                    errorNotificationHandler
                        .GetNotifications()
                        .Select(e => new Error(e.Code, e.Message));

            return new ServiceResponse(ServiceResponseStatus.Error, errors);
        }

        public AppService(IErrorNotificationHandler errorNotificationHandler) => 
            this.errorNotificationHandler = errorNotificationHandler;

        public bool IsValidOperation() => 
            (!errorNotificationHandler.HasNotifications());
    }
}