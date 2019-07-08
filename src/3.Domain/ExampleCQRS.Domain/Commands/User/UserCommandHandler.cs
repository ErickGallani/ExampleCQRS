namespace ExampleCQRS.Domain.Commands.User
{
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Core.Interfaces;

    public class UserCommandHandler : ICommandHandler<InsertUserCommand>
    {
        public UserCommandHandler()
        {

        }

        public async Task<bool> Handle(InsertUserCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
