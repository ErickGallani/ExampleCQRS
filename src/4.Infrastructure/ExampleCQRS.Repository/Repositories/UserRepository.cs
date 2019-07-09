namespace ExampleCQRS.Repository.Repositories
{
    using ExampleCQRS.Domain.Entities;
    using ExampleCQRS.Repository.Context;
    using ExampleCQRS.Repository.Interfaces;

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CQRSContext context) : 
            base(context)
        { }
    }
}