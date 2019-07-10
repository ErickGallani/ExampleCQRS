namespace ExampleCQRS.Domain.Entities
{
    using System;
    using ExampleCQRS.Domain.Core.Entities;
    using ExampleCQRS.Domain.ValueObjects;

    public class User : Entity
    {
        private User() { }

        public User(Guid id, Name name, Email email, BirthDate birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public BirthDate BirthDate { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}