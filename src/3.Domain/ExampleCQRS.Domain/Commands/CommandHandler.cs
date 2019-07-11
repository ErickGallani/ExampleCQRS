namespace ExampleCQRS.Domain.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Core.Interfaces;
    using ExampleCQRS.Domain.Interfaces;
    using FluentValidation.Results;

    public abstract class CommandHandler<TCommand> : ICommandHandler<TCommand>
        where TCommand : Command
    {
        protected readonly IEventPublisher eventPublisher;

        public CommandHandler(IEventPublisher eventPublisher) => 
            this.eventPublisher = eventPublisher;

        public delegate Task<bool> OnSuccessAsync(TCommand command);

        public delegate Task<bool> OnInvalidAsync(ValidationResult validationResult);

        protected async Task<bool> ExecuteHandlerAsync(
            TCommand command, 
            OnSuccessAsync onSuccessAsync, 
            OnInvalidAsync onInvalidAsync)
        {
            var validationResult = await command.IsValidAsync();

            if(!validationResult.IsValid)
                return await onInvalidAsync(validationResult);

            return await onSuccessAsync(command);
        }

        public abstract Task<bool> Handle(TCommand request, CancellationToken cancellationToken);
    }
}