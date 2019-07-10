namespace ExampleCQRS.Application.Services
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Adapters;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Domain.Commands.User;
    using ExampleCQRS.Domain.Core.Bus;

    public class UserService : IUserService
    {
        private readonly ICommandSender commandSender;

        public UserService(ICommandSender commandSender)
        {
            this.commandSender = commandSender;
        }

        public async Task<bool> InsertAsync(UserDto userDto)
        {
            var userAdapter = new UserDtoToUserAdapter();

            var user = userAdapter.Adapt(userDto);

            var insertUserCommand = new InsertUserCommand(user.Name, user.Email, user.BirthDate);

            return await this.commandSender.SendCommandAsync(insertUserCommand);
        }
    }
}