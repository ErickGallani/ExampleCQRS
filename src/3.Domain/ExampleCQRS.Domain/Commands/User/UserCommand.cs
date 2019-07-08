namespace ExampleCQRS.Domain.Commands.User
{
    using ExampleCQRS.Domain.Core.Interfaces;
    using System;

    public class UserCommand : ICommand
    {
        public Guid Id { get; protected set; }
    }
}
