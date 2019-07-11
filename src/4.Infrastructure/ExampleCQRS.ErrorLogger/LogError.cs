namespace ExampleCQRS.ErrorLogger
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Domain.Notifications;
    using Microsoft.Extensions.Logging;

    public class LogError : ILogError
    {
        private readonly ILogger logger;

        public LogError(ILogger logger)
        {
            this.logger = logger;
        }

        public Task LogAsync(ErrorNotification errorNotification)
        {
            return Task.Run(() => {
                this.logger?.LogError(
                    errorNotification.Message, 
                    errorNotification.Code,
                    errorNotification.EventId,
                    errorNotification.Timestamp);
            });
        }
    }
}