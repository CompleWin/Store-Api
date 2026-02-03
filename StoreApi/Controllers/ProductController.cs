using System.Net;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;

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


    [HttpGet("{id}", Name = nameof(GetProductById))]
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
        try
        {
            if (ModelState.IsValid)
            {
                if (createDto.Image is null
                    || createDto.Image.Length == 0)
                {
                    return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null,
                        "Image не может быть пустым!"));
                }

                Product item = new()
                {
                    Name = createDto.Name,
                    Description = createDto.Description,
                    Category = createDto.Category,
                    Price = createDto.Price,
                    SpecialTag = createDto.SpecialTag,
                    Image = "https://picsum.photos/200/300"
                };

                await dbContext.Products.AddAsync(item);
                await dbContext.SaveChangesAsync();
                
                return CreatedAtRoute(nameof(GetProductById), new { id = item.Id },
                    new ResponseServer(true, HttpStatusCode.Created, item, Array.Empty<string>()));
            }

            return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null, "Что-то не так с моделью"));
        }
        catch (Exception ex)
        {
            return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null, "Что-то пошло не так",
                ex.Message));
        }
    }

    [HttpPut]
    public async Task<ActionResult<ResponseServer>> UpdateProduct(
        int id,
        [FromBody] ProductUpdateDto updateDto)
    {
        try
        {
            if (id < 0 || id != updateDto.Id)
            {
                return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null, "Неккоректный id"));
            }
            
            Product item = await dbContext.Products.FirstOrDefaultAsync(e => e.Id == id);
            if (item is null)
            {
                return NotFound(new ResponseServer(false, HttpStatusCode.NotFound, null, "Товар с таким id не найден"));
            }
            
            item.Name = updateDto.Name;
            item.Description = updateDto.Description;
            item.Category = updateDto.Category;
            item.Price = updateDto.Price;
            item.SpecialTag = updateDto.SpecialTag ?? item.SpecialTag;

            if (updateDto.Image is not null && updateDto.Image.Length > 0)
            {
                item.Image = "https://picsum.photos/300/300";
            }

            dbContext.Products.Update(item);
            await dbContext.SaveChangesAsync();
            
            return Ok(new ResponseServer(true, HttpStatusCode.OK, item));
            
        }
        catch (Exception ex)
        {
            return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null, ex.Message));
        }
    }
}