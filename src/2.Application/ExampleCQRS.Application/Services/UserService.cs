namespace ExampleCQRS.Application.Services
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Adapters;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Domain.Commands.User;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Domain.ValueObjects;

    public class UserService : AppService, IUserService
    {
        private readonly ICommandSender commandSender;

        public UserService(
            ICommandSender commandSender, 
            IErrorNotificationHandler errorNotificationHandler) : 
            base(errorNotificationHandler)
        {
            this.commandSender = commandSender;
        }

        public async Task<bool> InsertAsync(UserDto userDto)
        {
            var name = new Name(userDto.FirstName, userDto.LastName);

            var email = new Email(userDto.Email);
            
            var birthDate = new BirthDate(userDto.BirthDate);

            var insertUserCommand = new InsertUserCommand(name, email, birthDate);

            var result = await this.commandSender.SendCommandAsync(insertUserCommand);

            if(!result) {
                var errors = GetErrors();
            }

            return result;
        }
    }
}