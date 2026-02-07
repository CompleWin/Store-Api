using Microsoft.EntityFrameworkCore;
using StoreApi.Common;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;

namespace StoreApi.Service;

public sealed class OrderService
{
    private readonly AppDbContext _dbContext;

    public OrderService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OrderHeader> CreateOrderAsync(
        OrderHeaderCreateDto orderHeaderCreateDto)
    {
        string status = string.IsNullOrEmpty(orderHeaderCreateDto.Status)
            ? SharedData.OrderStatus.Pending : orderHeaderCreateDto.Status;
        OrderHeader order = new OrderHeader
        {
            AppUserId = orderHeaderCreateDto.AppUserId,
            CustomerName = orderHeaderCreateDto.CustomerName,
            CustomerEmail = orderHeaderCreateDto.CustomerEmail,
            OrderTotalAmount = orderHeaderCreateDto.OrderTotalAmount,
            TotalCount = orderHeaderCreateDto.TotalCount,
            Status = status,
            OrderDateTime = DateTime.UtcNow
        };
        
        await _dbContext.OrderHeaders.AddAsync(order);
        await _dbContext.SaveChangesAsync();

        foreach (var orderDetailsDto in orderHeaderCreateDto.OrderDetailsDto)
        {
            OrderDetails orderDetails = new OrderDetails
            {
                OrderHeaderId = order.OrderHeaderId,
                ProductId = orderDetailsDto.ProductId,
                Quantity = orderDetailsDto.Quantity,
                ItemName = orderDetailsDto.ItemName,
                Price = orderDetailsDto.Price,
            };
            
            await _dbContext.OrderDetails.AddAsync(orderDetails);
        }
        
        await _dbContext.SaveChangesAsync();
        
        return order;
    }

    public async Task<OrderHeader?> GetOrderByIdAsync(int orderId)
    {
        return await  _dbContext.OrderHeaders
            .Include(i => i.OrderDetailsItems)
            .ThenInclude(i => i.Product)
            .FirstOrDefaultAsync(i => i.OrderHeaderId == orderId);
    }

    public async Task<IEnumerable<OrderHeader>> GetOrderByUserIdAsync(string userId)
    {
        var query = _dbContext.OrderHeaders
            .Include(i => i.OrderDetailsItems)
            .ThenInclude(i => i.Product)
            .OrderByDescending(o => o.AppUserId);

        if (!string.IsNullOrEmpty(userId))
        {
            return await query
                .Where(i => i.AppUserId == userId)
                .ToListAsync();
        }
        
        return await query.ToListAsync();
        
    }
    
    public async Task<bool> UpdateOrderHeaderAsync(int orderHeaderId, 
        OrderHeaderUpdateDto orderHeaderUpdateDto)
    {
        if (orderHeaderUpdateDto is null
            || orderHeaderId != orderHeaderUpdateDto.OrderHeaderId)
        {
            return false;
        }

        var orderFromDb = await _dbContext.OrderHeaders
            .FirstOrDefaultAsync(order => order.OrderHeaderId == orderHeaderId);

        if (orderFromDb is null)
        {
            return false;
        }

        if (!string.IsNullOrEmpty(orderHeaderUpdateDto.CustomerEmail))
        {
            orderFromDb.CustomerEmail = orderHeaderUpdateDto.CustomerEmail;
        }
        
        if (!string.IsNullOrEmpty(orderHeaderUpdateDto.CustomerName))
        {
            orderFromDb.CustomerName = orderHeaderUpdateDto.CustomerName;
        }
        
        if (!string.IsNullOrEmpty(orderHeaderUpdateDto.Status))
        {
            orderFromDb.Status = orderHeaderUpdateDto.Status;
        }
        
        await _dbContext.SaveChangesAsync();
        return true;
    }
    
    
}