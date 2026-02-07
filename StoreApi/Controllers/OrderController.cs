using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;
using StoreApi.Service;

namespace StoreApi.Controllers;

[Route("api/[controller]/[action]")]
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

    [HttpGet("{id}")]
    public async Task<ActionResult<ResponseServer>> GetOrderById(int id)
    {
        if (id <= 0)
        {
            return BadRequest(ResponseServer.CreateBadRequest("Not valid"));
        }

        try
        {
            var order = await _orderService.GetOrderByIdAsync(id);

            if (order is not null)
            {
                return Ok(ResponseServer.CreateOk(order));
            }

            return NotFound(ResponseServer.CreateBadRequest("Order not found"));
        }
        catch (Exception ex)
        {
            return BadRequest(ResponseServer.CreateBadRequest(ex.Message));
        }
    }

    [HttpGet("{userId:guid}")]
    public async Task<ActionResult<ResponseServer>> GetOrdersByUserId(string userId)
    {
        try
        {
            var userHeaders = await _orderService.GetOrderByUserIdAsync(userId);
            return Ok(ResponseServer.CreateOk(true));
        }
        catch (Exception ex)
        {
            return BadRequest(ResponseServer.CreateBadRequest(ex.Message));
        }
    }


    [HttpPut("{orderId}")]
    public async Task<ActionResult<ResponseServer>> UpdateOrderHeader(int orderId,
        [FromBody] OrderHeaderUpdateDto updateDto)
    {
        try
        {
            bool isSucces = await _orderService.UpdateOrderHeaderAsync(orderId, updateDto);
            if (!isSucces)
            {
                return BadRequest(ResponseServer.CreateBadRequest("Something went wrong"));
            }
            
            return Ok(ResponseServer.CreateOk(orderId));
        }
        catch (Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, new ResponseServer(false,
                HttpStatusCode.InternalServerError,
                null,
                "Internal Server Error", ex.Message));
        }
    }
}