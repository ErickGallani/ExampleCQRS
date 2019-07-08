namespace ExampleCQRS.Domain.Core.Bus
{
    using ExampleCQRS.Domain.Core.Interfaces;
    using System.Threading.Tasks;

    public interface ICommandSender
    {
        Task<bool> SendCommandAsync<TCommand>(TCommand command)
            where TCommand : ICommand;
    }
}
