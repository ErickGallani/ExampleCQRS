namespace ExampleCQRS.Application.Extensions.DependencyInjection
{
    using ExampleCQRS.Application.Bus;
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

        public static IServiceCollection AddQueries(this IServiceCollection services)
        {
            // Query fetch mediator bus
            services.AddScoped<IQueryFetcher, QueryFetcher>();

            return services;
        }
    }
}
