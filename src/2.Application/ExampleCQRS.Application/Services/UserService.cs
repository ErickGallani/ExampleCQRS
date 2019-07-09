namespace ExampleCQRS.Application.Services
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Core.Interfaces;

    public class UserService : IUserService
    {
        private readonly ICommandSender commandSender;

        public UserService(ICommandSender commandSender)
        {
            this.commandSender = commandSender;
        }

        public async Task<bool> Insert()
        {
            return await this.commandSender.SendCommandAsync(null as ICommand);
        }
    }
}