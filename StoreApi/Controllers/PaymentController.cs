using System.Net;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.Service.Payment;

namespace StoreApi.Controllers;

public sealed class PaymentController : StoreController
{
    private readonly IPaymentService _paymentService;

    public PaymentController(AppDbContext dbContext,
        IPaymentService paymentService) : base(dbContext)
    {
        _paymentService = paymentService;
    }

    [HttpPost]
    public async Task<ActionResult<ResponseServer>> MakePayment(string userId,
        int orderId, string cardNumber)
    {
        try
        {
            return await _paymentService.HandlePaymentAsync(userId, orderId, cardNumber);
        }
        catch (Exception ex)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError,
                new ResponseServer
                {
                    IsSucces = false,
                    ErrorMessages = { ex.Message }
                });
        }
    }
}