namespace ExampleCQRS.Application.Interfaces
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Application.Services;

    public interface IUserService
    {
        Task<ServiceResponse> InsertAsync(UserDto userDto);
    }
}