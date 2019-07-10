namespace ExampleCQRS.Domain.Commands
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Interfaces;

    public abstract class CommandHandler<TCommand> : ICommandHandler<TCommand>
        where TCommand : Command
    {
        public delegate Task<bool> OnSuccessAsync();

        public delegate Task<bool> OnInvalidAsync();

        protected async Task<bool> ExecuteHandlerAsync(
            TCommand command, 
            OnSuccessAsync onSuccessAsync, 
            OnInvalidAsync onInvalidAsync)
        {
            var validationResult = await command.IsValidAsync();

            if(!validationResult.IsValid)
            {
                return await onInvalidAsync();
            }

            return await onSuccessAsync();
        }

        public abstract Task<bool> Handle(TCommand request, CancellationToken cancellationToken);
    }
}