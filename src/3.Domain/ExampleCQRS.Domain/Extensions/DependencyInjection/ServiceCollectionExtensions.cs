namespace ExampleCQRS.Domain.Extensions.DependencyInjection
{
    using ExampleCQRS.Domain.Bus;
    using ExampleCQRS.Domain.Commands.User;
    using ExampleCQRS.Domain.Core.Bus;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static void AddCommands(this IServiceCollection services)
        {
            // Command bus handler
            services.AddScoped<ICommandSender, CommandSender>();

            // User commands
            services.AddScoped<IRequestHandler<InsertUserCommand, bool>, UserCommandHandler>();
        }
    }
}
