using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.Service;

namespace StoreApi.Controllers;

[Route("api/[controller]/[action]")]
public class ShoppingCartController : StoreController
{
    private readonly ShoppingCartService _shoppingCartService;
    
    public ShoppingCartController(AppDbContext dbContext, ShoppingCartService shoppingCartService) : 
        base(dbContext)
    {
        _shoppingCartService = shoppingCartService;
    }

    [HttpGet]
    public async Task<ActionResult<ResponseServer>> AppendOrUpdateItemInCart(
        string userId, int productId, int updateQuantity)
    {
        Product? product = await dbContext
            .Products
            .FirstOrDefaultAsync(p => p.Id == productId);

        if (product is null)
        {
            return BadRequest(ResponseServer.CreateBadRequest("Product not found"));
        }

        ShoppingCart? shoppingCart = await dbContext
            .ShoppingCarts
            .Include(s => s.CartItems)
            .FirstOrDefaultAsync(s => s.UserId == userId);

        if (shoppingCart is null && updateQuantity > 0)
        {
            await _shoppingCartService.CreateNewCartAsync(userId, productId, updateQuantity);
        }
        else if (shoppingCart is not null)
        {
            await _shoppingCartService.UpdateExistingCartAsync(shoppingCart, productId, updateQuantity);
        }

        return Ok(ResponseServer.CreateOk());
    }

    [HttpGet]
    public async Task<ActionResult<ResponseServer>> GetShoppingCart(string userId)
    {
        try
        {
            ShoppingCart shoppingCart = await _shoppingCartService
                .GetShoppingCartAsync(userId);
        
            return Ok(ResponseServer.CreateOk(shoppingCart));
            
        } catch (Exception ex)
        {
            return BadRequest(ResponseServer.CreateBadRequest(ex.Message));
        }
    }
}