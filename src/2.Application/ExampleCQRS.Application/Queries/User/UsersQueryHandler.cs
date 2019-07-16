namespace ExampleCQRS.Application.Queries.User
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Domain.Core.Bus;

    public class UsersQueryHandler : 
        QueryHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        public UsersQueryHandler(/*IUserReader userReader,*/ IEventPublisher eventPublisher) : 
            base(eventPublisher)
        { }

        public override Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}