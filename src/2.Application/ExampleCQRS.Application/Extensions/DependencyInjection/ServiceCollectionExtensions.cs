namespace ExampleCQRS.Application.Extensions.DependencyInjection
{
    using ExampleCQRS.Application.Interfaces;
    using ExampleCQRS.Application.Services;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // User service
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
