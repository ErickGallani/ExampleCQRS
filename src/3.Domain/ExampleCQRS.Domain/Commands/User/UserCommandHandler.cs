namespace ExampleCQRS.Domain.Commands.User
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.CrossCutting.ErrorCodes;
    using ExampleCQRS.CrossCutting.ErrorMappings;
    using ExampleCQRS.CrossCutting.Extensions;
    using ExampleCQRS.Domain.Adapters;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Domain.Notifications;
    using FluentValidation.Results;

    public class UserCommandHandler : 
        CommandHandler<InsertUserCommand>
    {
        private readonly IUserRepository userRepository;

        public UserCommandHandler(
            IUserRepository userRepository,
            IEventPublisher eventPublisher) :
            base(eventPublisher) => 
            this.userRepository = userRepository;

        public override async Task<bool> Handle(InsertUserCommand request, CancellationToken cancellationToken) =>
            await ExecuteHandlerAsync(request, OnSuccess, OnInvalid);

        private async Task<bool> OnInvalid(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors) 
            {
                await this.eventPublisher.PublishEventAsync(
                    new ErrorNotification(
                        error.ErrorCode, 
                        error.ErrorMessage));
            }

            return false;
        }

        private async Task<bool> OnSuccess(InsertUserCommand request)
        {   
            if(await this.userRepository.GetByEmailAsync(request.Email) != null)
            {
                await this.eventPublisher.PublishEventAsync(
                    new ErrorNotification(
                        UserError.Code.UserAlreadyExists.GetString(), 
                        UserErrorMapping.Map[UserError.Code.UserAlreadyExists]));

                return false;
            }

            var adapter = new InsertUserCommandToUserAdapter();
            
            var user = adapter.Adapt(request);

            if (user is null)
                return false;

            await this.userRepository.InsertAsync(user);

            return await Task.FromResult(true);
        }
        
    }
}
