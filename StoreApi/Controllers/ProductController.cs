using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;

namespace StoreApi.Controllers;
[Route("api/[controller]/[action]")]
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

    
    [HttpGet]
    public async Task<IActionResult> GetProductById(int id)
    {

        ResponseServer response = new ResponseServer();
        if (id <= 0)
        {
            response.IsSucces = false;
            response.StatusCode = HttpStatusCode.BadRequest;
            response.ErrorMessages.Add("Неверно указанный id. Должен быть >= 0");
            return BadRequest(response);
        }

        Product product = await dbContext.Products.FirstOrDefaultAsync(e => e.Id == id);

        if (product is null)
        {
            response.IsSucces = false;
            response.StatusCode = HttpStatusCode.NotFound;
            response.ErrorMessages.Add("Товар по указанному id не найден");
            return NotFound(response);
        }

        response.StatusCode = HttpStatusCode.OK;
        response.Response = product;
        return Ok(response);
    }

    [HttpPost]
    public async Task<ActionResult<ResponseServer>> CreateProduct(
        [FromBody] ProductCreateDto createDto)
    {
        
    }
}