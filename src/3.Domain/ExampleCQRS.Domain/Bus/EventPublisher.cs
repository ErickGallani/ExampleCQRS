namespace ExampleCQRS.Domain.Bus
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Core.Events;
    using MediatR;

    public class EventPublisher : IEventPublisher
    {
        private readonly IMediator mediator;

        public EventPublisher(IMediator mediator) => 
            this.mediator = mediator;

        public Task PublishEventAsync<TEvent>(TEvent @event)
            where TEvent : IEvent => 
            this.mediator.Publish(@event);
    }
}