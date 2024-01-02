using Microsoft.EntityFrameworkCore;
using TaskManagement.Infrastructure.Context;

namespace TaskManagement.Api.Extensions
{
    public static class DatabaseServiceExtensions
    {
        public static void AddDatabaseService(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("LocalConnection");
            //string? connectionString = configuration.GetConnectionString("ServerConnection");

            services
                .AddDbContext<TaskManagementDbContext>(options =>
                {
                    options.UseSqlServer(
                        connectionString,
                        dbOptions => dbOptions.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds)
                                              .MigrationsAssembly("TaskManagement.Infrastructure"));
                });
        }
    }
}
