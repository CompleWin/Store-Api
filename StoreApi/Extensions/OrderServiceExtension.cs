using StoreApi.Service;

namespace StoreApi.Extensions;

public static class OrderServiceExtension
{
    public static IServiceCollection AddOrderService(
        this IServiceCollection services)
    {
        return services.AddScoped<OrderService>();
    }
}