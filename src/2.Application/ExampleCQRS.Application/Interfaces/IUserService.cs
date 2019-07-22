namespace ExampleCQRS.Application.Interfaces
{
    using System.Threading.Tasks;
    using ExampleCQRS.Application.Dtos;
    using ExampleCQRS.Application.Services.Response;

    public interface IUserService
    {
        Task<ServiceResponse> InsertAsync(UserDto userDto);
    }
}