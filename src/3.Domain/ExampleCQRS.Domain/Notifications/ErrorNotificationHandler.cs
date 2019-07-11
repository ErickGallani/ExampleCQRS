namespace ExampleCQRS.Domain.Notifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Interfaces;

    public class ErrorNotificationHandler : IErrorNotificationHandler, IDisposable
    {
        private IList<ErrorNotification> notifications;
        private readonly ILogError logError;

        public ErrorNotificationHandler(ILogError logError)
        {
            notifications = new List<ErrorNotification>();
            
            this.logError = logError;
        }

        public async Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            await this.logError.LogAsync(notification);

            notifications.Add(notification);
        }

        public IList<ErrorNotification> GetNotifications() => notifications;

        public bool HasNotifications() => 
            GetNotifications().Any();

        public void Dispose() => 
            notifications = new List<ErrorNotification>();
    }
}