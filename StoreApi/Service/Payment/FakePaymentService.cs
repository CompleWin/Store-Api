using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Common;
using StoreApi.Data;
using StoreApi.Model;

namespace StoreApi.Service.Payment;

public sealed class FakePaymentService : IPaymentService
{
    private readonly AppDbContext _dbContext;

    public FakePaymentService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    
    public async Task<ActionResult<ResponseServer>> HandlePaymentAsync(string userId, 
        int orderHeaderId, string cardNumber)
    {
        var shoppingCart = await _dbContext
            .ShoppingCarts
            .Include(s => s.CartItems)
            .ThenInclude(s => s.Product)
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (shoppingCart is null ||
            shoppingCart.CartItems is null ||
            shoppingCart.CartItems.Count == 0)
        {
            return new BadRequestObjectResult(
                ResponseServer.CreateBadRequest("Something wrong with shopping cart"));
        }

        var orderHeader = await _dbContext.OrderHeaders
            .FindAsync(orderHeaderId);

        if (orderHeader is null)
        {
            return new BadRequestObjectResult(
                ResponseServer.CreateBadRequest("Order header not found"));
        }
        
        shoppingCart.TotalAmount = shoppingCart
            .CartItems
            .Sum(s => s.Quantity * s.Product.Price);

        if (shoppingCart.TotalAmount <= 0)
        {
            return new BadRequestObjectResult(
                ResponseServer.CreateBadRequest("Something wrong with shopping cart total amount"));
        }

        await Task.Delay(5000);
        
        PaymentResponse response;
        if (cardNumber == "1111 2222 3333 4444")
        {
            response = new PaymentResponse
            {
                Success = true,
                IntentId = "intentId",
                Secret = "secret"
            };
        }
        else
        {
            response = new PaymentResponse
            {
                Success = false,
                IntentId = String.Empty,
                Secret = String.Empty,
                ErrorMessage = "Wrong card number"
            };
        }

        if (!response.Success)
        {
            return new BadRequestObjectResult(
                ResponseServer.CreateBadRequest(response.ErrorMessage));
        }

        orderHeader.Status = SharedData.OrderStatus.ReadyToShip;

        await _dbContext.SaveChangesAsync();
        
        return new OkObjectResult(
            new ResponseServer
            {
                IsSucces = true,
                StatusCode = HttpStatusCode.OK,
                Response = response
            });

    }
}