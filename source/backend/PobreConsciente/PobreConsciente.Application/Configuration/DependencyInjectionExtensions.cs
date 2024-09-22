using Microsoft.Extensions.DependencyInjection;
using PobreConsciente.Application.Notification;

namespace PobreConsciente.Infrastructure.Configuration;

public static class DependencyInjectionExtensions
{
    public static void AddApplicationDependency(this IServiceCollection services)
    {
        services.AddScoped<INotificationManager, NotificationManager>();
    }
}