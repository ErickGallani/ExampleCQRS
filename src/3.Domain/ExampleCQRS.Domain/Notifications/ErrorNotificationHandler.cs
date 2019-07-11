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

        public ErrorNotificationHandler() => 
            notifications = new List<ErrorNotification>();

        public Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            notifications.Add(notification);

            return Task.CompletedTask;
        }

        public IList<ErrorNotification> GetNotifications() => notifications;

        public bool HasNotifications() => 
            GetNotifications().Any();

        public void Dispose() => 
            notifications = new List<ErrorNotification>();
    }
}