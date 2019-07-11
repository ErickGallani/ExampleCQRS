namespace ExampleCQRS.Application.Adapters
{
    using ExampleCQRS.Application.Errors;
    using ExampleCQRS.CrossCutting.Adapters;
    using ExampleCQRS.Domain.Notifications;

    public class ErrorNotificationToErrorAdapter : IAdapter<ErrorNotification, Error>
    {
        public Error Adapt(ErrorNotification source)
        {
            if(source is null) 
            {
                return default(Error);
            }

            return new Error(source.Code, source.Message);
        }
    }
}