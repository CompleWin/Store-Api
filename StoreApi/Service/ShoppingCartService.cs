using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;

namespace StoreApi.Service;

public sealed class ShoppingCartService
{
    private readonly AppDbContext _dbContext;
    
    public ShoppingCartService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task CreateNewCartAsync(string userId, int productId, int quantity)
    {
        ShoppingCart newCart = new ShoppingCart
        {
            UserId = userId
        };
        
        await _dbContext.ShoppingCarts.AddAsync(newCart);
        await _dbContext.SaveChangesAsync();

        CartItem newCartItem = new CartItem
        {
            ProductId = productId,
            Quantity = quantity,
            ShoppingCartId = newCart.Id,
            Product = null
        };
        
        await _dbContext.CartItems.AddAsync(newCartItem);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateExistingCartAsync(
        ShoppingCart shoppingCart, int productId, int newQuantity)
    {
        CartItem cartItemInCart = shoppingCart
            .CartItems
            .FirstOrDefault(c => c.Id == productId);

        if (cartItemInCart is null && newQuantity > 0)
        {
            CartItem cartItem = new CartItem
            {
                ProductId = productId,
                Quantity = newQuantity,
                ShoppingCartId = shoppingCart.Id
            };
            
            await _dbContext.CartItems.AddAsync(cartItem);
        }
        
        else if (cartItemInCart is not null)
        {
            if (newQuantity <= 0)
            {
                _dbContext.CartItems.Remove(cartItemInCart);

                if (shoppingCart.CartItems.Count == 1)
                {
                    _dbContext.ShoppingCarts.Remove(shoppingCart);
                }
            }
            else
            {
                cartItemInCart.Quantity = newQuantity;
            }
        }
        
        await _dbContext.SaveChangesAsync();
    }

    public async Task<ShoppingCart> GetShoppingCartAsync(string userId)
    {
        if (string.IsNullOrEmpty(userId))
        {
            return new ShoppingCart();
        }
        
        ShoppingCart shoppingCart = await _dbContext
            .ShoppingCarts
            .Include(s => s.CartItems)
            .ThenInclude(s => s.Product)
            .FirstOrDefaultAsync(s => s.UserId ==  userId);

        if (shoppingCart is not null && shoppingCart.CartItems is not null)
        {
            shoppingCart.TotalAmount = shoppingCart
                .CartItems
                .Sum(s => s.Quantity * s.Product.Price);
        }
        return shoppingCart;
    }
    
}