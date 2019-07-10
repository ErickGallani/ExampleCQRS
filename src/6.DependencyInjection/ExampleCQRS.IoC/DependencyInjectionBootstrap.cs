namespace ExampleCQRS.IoC
{
    using ExampleCQRS.Application.Extensions.DependencyInjection;
    using ExampleCQRS.Domain.Extensions.DependencyInjection;
    using ExampleCQRS.Repository.Extensions.DependencyInjection;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjectionBootstrap
    {
        public static void Setup(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddCommands()
                .AddServices()
                .AddRepositories(configuration);
        }
    }
}