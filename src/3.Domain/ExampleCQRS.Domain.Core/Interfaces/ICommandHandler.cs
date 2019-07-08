namespace ExampleCQRS.Domain.Core.Interfaces
{
    using MediatR;

    public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, bool>
        where TCommand : ICommand
    {
    }
}
