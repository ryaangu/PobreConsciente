using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PobreConsciente.Infrastructure.Context;

namespace PobreConsciente.Infrastructure.Configuration;

public static class DependencyInjectionExtensions
{
    public static void AddInfrastructureDependency(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
    }
}