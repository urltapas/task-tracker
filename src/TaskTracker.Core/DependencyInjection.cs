using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using TaskTracker.Core.Database;

namespace TaskTracker.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddCoreDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("SqlConnection");
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connectionString));

        return services;
    }
}