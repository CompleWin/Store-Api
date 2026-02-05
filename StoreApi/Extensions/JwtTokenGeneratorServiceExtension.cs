using StoreApi.Service;

namespace StoreApi.Extensions;

public static class JwtTokenGeneratorServiceExtension
{
    public static IServiceCollection AddJwtTokenGenerator(
        this IServiceCollection services)
    {
        services.AddScoped<JwtTokenGenerator>();
        return services;
    }
}