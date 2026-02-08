using Microsoft.AspNetCore.Mvc;
using StoreApi.Model;

namespace StoreApi.Service.Payment;

public interface IPaymentService
{
    Task<ActionResult<ResponseServer>> HandlePaymentAsync(string userId,
        int orderHeaderId, string cardNumber);
}