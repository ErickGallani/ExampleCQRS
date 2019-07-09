namespace ExampleCQRS.Application.Interfaces
{
    using System.Threading.Tasks;
    
    public interface IUserService : IAppService
    {
        Task<bool> Insert();
    }
}