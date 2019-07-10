namespace ExampleCQRS.Domain.Interfaces
{
    using System.Threading.Tasks;
    using ExampleCQRS.Domain.Entities;

    public interface IUserRepository
    {
        Task<int> InserAsync(User user);
    }
}