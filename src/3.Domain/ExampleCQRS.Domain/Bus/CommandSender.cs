namespace ExampleCQRS.Domain.Bus
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Core.Interfaces;
    using MediatR;

    public class CommandSender : ICommandSender
    {
        private readonly IMediator mediator;

        public CommandSender(IMediator mediator) => 
            this.mediator = mediator;

        public async Task<bool> SendCommandAsync<TCommand>(TCommand command)
            where TCommand : ICommand => 
            await this.mediator.Send(command);
    }
}
