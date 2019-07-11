namespace ExampleCQRS.Domain.Core.Bus
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Events;

    public interface IEventPublisher
    {
        Task PublishEventAsync<TEvent>(TEvent @event) 
            where TEvent : IEvent;
    }
}
