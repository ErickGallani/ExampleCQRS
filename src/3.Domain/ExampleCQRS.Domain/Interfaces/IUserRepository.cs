namespace ExampleCQRS.Domain.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Entities;
    using ExampleCQRS.Domain.ValueObjects;

    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(Email email);

        Task<User> GetByIdAsync(Guid id);

        Task<int> InsertAsync(User user);

        Task<int> UpdateAsync(User user);

        Task<int> DeleteAsync(User user);
    }
}