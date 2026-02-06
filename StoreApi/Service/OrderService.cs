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
            Status = status
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

}