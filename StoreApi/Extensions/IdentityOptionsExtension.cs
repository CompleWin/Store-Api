using Microsoft.AspNetCore.Identity;

namespace StoreApi.Extensions;

public static class IdentityOptionsExtension
{
    public static IServiceCollection AddConfigureIdentityOptions(
        this IServiceCollection services)
    {
        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 1;
            options.Password.RequiredUniqueChars = 0;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
        });
        return services;
    }
}