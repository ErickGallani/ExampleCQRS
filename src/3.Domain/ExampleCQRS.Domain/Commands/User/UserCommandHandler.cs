namespace ExampleCQRS.Domain.Commands.User
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Adapters;
    using ExampleCQRS.Domain.Interfaces;

    public class UserCommandHandler : 
        CommandHandler<InsertUserCommand>
    {
        private readonly IUserRepository userRepository;

        public UserCommandHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public override async Task<bool> Handle(InsertUserCommand request, CancellationToken cancellationToken) =>
            await ExecuteHandlerAsync(request, OnSuccess, OnInvalid);

        private Task<bool> OnInvalid()
        {
            return Task.FromResult(false);
        }

        private async Task<bool> OnSuccess(InsertUserCommand request)
        {
            if (request is null)
            {
                return false;
            }
            
            var adapter = new InsertUserCommandToUserAdapter();
            
            var user = adapter.Adapt(request);

            if (user is null)
            {
                return false;
            }

            await this.userRepository.InserAsync(user);

            return await Task.FromResult(true);
        }
    }
}
