namespace ExampleCQRS.ErrorLogger
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Domain.Notifications;
    using Microsoft.Extensions.Logging;

    public class LogError : ILogError
    {
        private readonly ILogger logger;

        public LogError(ILoggerFactory loggerFactory) => 
            this.logger = loggerFactory.CreateLogger<ErrorNotification>();

        public Task LogAsync(ErrorNotification errorNotification) => 
            Task.Run(() => this.logger?.LogError(
                errorNotification.Message,
                errorNotification.Code,
                errorNotification.EventId,
                errorNotification.Timestamp));
    }
}