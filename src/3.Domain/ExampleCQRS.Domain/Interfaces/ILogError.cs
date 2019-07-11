namespace ExampleCQRS.Domain.Interfaces
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Notifications;

    public interface ILogError
    {
         Task LogAsync(ErrorNotification errorNotification);
    }
}