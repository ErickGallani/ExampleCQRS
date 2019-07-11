namespace ExampleCQRS.Domain.Extensions.DependencyInjection
{
    using ExampleCQRS.Domain.Bus;
    using ExampleCQRS.Domain.Commands.User;
    using ExampleCQRS.Domain.Core.Bus;
    using ExampleCQRS.Domain.Interfaces;
    using ExampleCQRS.Domain.Notifications;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommands(this IServiceCollection services)
        {
            // Command bus handler
            services.AddScoped<ICommandSender, CommandSender>();

            // Event publishers
            services.AddScoped<IEventPublisher, EventPublisher>();

            services.AddScoped<ErrorNotificationHandler>();
            services.AddScoped<IErrorNotificationHandler>(
                serviceProvider => serviceProvider.GetService<ErrorNotificationHandler>());
            services.AddScoped<INotificationHandler<ErrorNotification>>(
                serviceProvider => serviceProvider.GetService<ErrorNotificationHandler>());

            // User commands
            services.AddScoped<IRequestHandler<InsertUserCommand, bool>, UserCommandHandler>();

            return services;
        }
    }
}
