namespace ExampleCQRS.Domain.Core.Events
{
    using System;

    public abstract class Event : IEvent
    {
        protected Event()
        {
            this.Timestamp = DateTime.UtcNow;
            this.EventId = Guid.NewGuid();
        }

        public DateTime Timestamp { get; private set; }

        public Guid EventId { get; private set; }   
    }
}