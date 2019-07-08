namespace ExampleCQRS.Domain.Core.Entities
{
    using System;
    
    public class Entity
    {
        public Guid Id { get; protected set; }
    }
}