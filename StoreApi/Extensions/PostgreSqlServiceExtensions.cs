using Microsoft.EntityFrameworkCore;
using StoreApi.Data;

namespace StoreApi.Extensions;

public static class PostgreSqlServiceExtensions
{
    public static void AddPostgreSqlDbContext(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection"));
        });
    }

}