namespace ExampleCQRS.Repository.Extensions.DependencyInjection
{
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Repository.Context;
    using ExampleCQRS.Repository.Repositories;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            // Add repository
            services.AddScoped<IUserRepository, UserRepository>();

            // Adding Db Context
            services
                .AddEntityFrameworkMySql()
                .AddDbContext<CQRSContext>(
                    options => options.UseMySql(configuration.GetConnectionString("CQRSDataBase")), 
                    ServiceLifetime.Scoped);

            return services;
        }
    }
}