using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;

namespace StoreApi.Controllers;

public class ProductController : StoreController
{
    public ProductController(AppDbContext dbContext) : base(dbContext)
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        ResponseServer response = new ResponseServer
        {
            StatusCode = HttpStatusCode.OK,
            Response = await dbContext.Products.ToListAsync()
        };
        return Ok(response);
    }
}