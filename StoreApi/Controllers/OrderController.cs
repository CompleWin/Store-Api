using Microsoft.AspNetCore.Mvc;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;
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

    [HttpPost]
    public async Task<ActionResult<ResponseServer>> CreateOrder(
        [FromBody] OrderHeaderCreateDto orderHeaderCreateDto)
    {
        try
        {
            var order = await _orderService.CreateOrderAsync(orderHeaderCreateDto);
            return Ok(ResponseServer.CreateOk(order));
        }
        catch (Exception ex)
        {
            return BadRequest(ResponseServer.CreateBadRequest(ex.Message));
        }
        
        
    }
}