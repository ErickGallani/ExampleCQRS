namespace ExampleCQRS.Domain.Commands.User
{
    using System;

    public abstract class UserCommand : Command
    {
        public Guid Id { get; protected set; }
    }
}
