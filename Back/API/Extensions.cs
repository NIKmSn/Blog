using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace API
{
    public static class Extensions
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            // Manually run any pending migrations if configured to do so
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (env == "Production")
            {
                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var dbContext = services.GetRequiredService<BlogContext>();
                    dbContext.Database.Migrate();
                }
            }

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<BlogContext>();
                dbContext.Database.Migrate();
            }

            return host;
        }
    }
}
