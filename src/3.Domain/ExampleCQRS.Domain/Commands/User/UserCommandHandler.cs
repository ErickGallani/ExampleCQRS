namespace ExampleCQRS.Domain.Commands.User
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Interfaces;

    public class UserCommandHandler : 
        CommandHandler<InsertUserCommand>
    {
        public UserCommandHandler()
        {

        }

        public override async Task<bool> Handle(InsertUserCommand request, CancellationToken cancellationToken) =>
            await ExecuteHandlerAsync(request, OnSuccess, OnInvalid);

        private Task<bool> OnInvalid()
        {
            return Task.FromResult(false);
        }

        private Task<bool> OnSuccess()
        {
            // save on the repository

            return Task.FromResult(true);
        }
    }
}
