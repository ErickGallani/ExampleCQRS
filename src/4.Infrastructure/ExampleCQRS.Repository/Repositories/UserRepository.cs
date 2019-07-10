namespace ExampleCQRS.Repository.Repositories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Entities;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Domain.ValueObjects;
    using ExampleCQRS.Repository.Context;

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CQRSContext context) : 
            base(context)
        { }

        /*
        Needs to be "user => user.Email.Value == email.Value" because
        "user => user.Email == email" works but EntityFramework is unable to
        generate the WHERE clause on SQL using the ValueObject so using the
        ValueObject compare will query without where clause and filter locally in memory.
        
        So for performance reasons we should avoid using ValueObject comparison until
        EntityFramework can handle this operation
        */
        public async Task<User> GetByEmailAsync(Email email) => 
            await Task.FromResult(
                this.context.User.FirstOrDefault(
                    user => user.Email.Value == email.Value));
    }
}