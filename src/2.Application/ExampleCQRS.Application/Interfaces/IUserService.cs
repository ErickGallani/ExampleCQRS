namespace ExampleCQRS.Application.Interfaces
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;

    public interface IUserService : IAppService
    {
        Task<bool> InsertAsync(UserDto userDto);
    }
}