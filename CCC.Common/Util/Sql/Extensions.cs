using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CCC.Common.Util.Sql
{
    public static class Extensions
    {
        public static IServiceCollection AddNpgSqlContext<TContext>(this IServiceCollection services, string connection, IConfiguration configuration) where TContext : DbContext
        {
            services.AddScoped<SqlExecptionHandler>();
            return services.AddDbContext<TContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString(connection), assembly =>
                { 
                    assembly.MigrationsAssembly("CCC.Data");
                });
            },
            ServiceLifetime.Scoped);
        }
    }
}
