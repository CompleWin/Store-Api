using StoreApi.Data;
using StoreApi.Service;

namespace StoreApi.Controllers;

public sealed class OrderController : StoreController 
{
    private readonly OrderService _orderService;

    public OrderController(
        AppDbContext dbContext, 
        OrderService orderService) : base(dbContext)
    {
        _orderService = orderService;
    }
}