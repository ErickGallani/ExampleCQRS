namespace ExampleCQRS.ErrorLogger.Extensions.DependencyInjection
{
    using ExampleCQRS.Domain.Interfaces;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddErrorLogger(this IServiceCollection services)
        {
            // Error notification logger
            services.AddScoped<ILogError, LogError>();

            return services;
        }
    }
}