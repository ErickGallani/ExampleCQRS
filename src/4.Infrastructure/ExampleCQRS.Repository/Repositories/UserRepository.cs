namespace ExampleCQRS.Repository.Repositories
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Entities;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Repository.Context;

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CQRSContext context) : 
            base(context)
        { }

        public async Task<int> InserAsync(User user)
        {
            return await this.AddAsync(user);
        }
    }
}