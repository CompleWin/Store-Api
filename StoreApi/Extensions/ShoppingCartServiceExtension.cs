using StoreApi.Service;

namespace StoreApi.Extensions;

public static class ShoppingCartServiceExtension
{
    public static IServiceCollection AddShoppingCartService(this IServiceCollection services)
    {
        return services.AddScoped<ShoppingCartService>();
    }
}