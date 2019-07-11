namespace ExampleCQRS.Domain.Interfaces
{
    using System.Collections.Generic;
    using ExampleCQRS.Domain.Notifications;
    using MediatR;

    public interface IErrorNotificationHandler : INotificationHandler<ErrorNotification>
    {
        IList<ErrorNotification> GetNotifications();

        bool HasNotifications();
    }
}