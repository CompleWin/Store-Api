using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;

namespace StoreApi.Extensions;

public static class PostgreSqlServiceExtensions
{
    public static IServiceCollection AddPostgreSqlDbContext(this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection"));
        });
        
        return services;
    }

    public static IServiceCollection AddPostgreSqlIdentityContext(this IServiceCollection services)
    {
        services.AddIdentity<AppUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>();
        
        return services;
    }

}