using System.Net;
using Bogus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;
using StoreApi.Service.Storage;

namespace StoreApi.Controllers;

public class ProductController : StoreController
{
    private readonly IFileStorageService _fileStorageService;

    public ProductController(AppDbContext dbContext,
        IFileStorageService fileStorageService) : base(dbContext)
    {
        _fileStorageService = fileStorageService;
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
        [FromForm] ProductCreateDto createDto)
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
                    Image = await _fileStorageService.UploadFileAsync(createDto.Image)
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
        [FromForm] ProductUpdateDto updateDto)
    {
        try
        {
            if (id < 0 || id != updateDto.Id)
            {
                return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null, "Неккоректный id"));
            }
            
            Product productFromDb = await dbContext.Products.FirstOrDefaultAsync(e => e.Id == id);
            if (productFromDb is null)
            {
                return NotFound(new ResponseServer(false, HttpStatusCode.NotFound, null, "Товар с таким id не найден"));
            }
            
            productFromDb.Name = updateDto.Name;
            productFromDb.Description = updateDto.Description;
            productFromDb.Category = updateDto.Category;
            productFromDb.Price = updateDto.Price;
            productFromDb.SpecialTag = updateDto.SpecialTag ?? productFromDb.SpecialTag;

            if (updateDto.Image is not null && updateDto.Image.Length > 0)
            {
                await _fileStorageService.RemoveFileAsync(productFromDb.Image.Split('/').Last());
                productFromDb.Image = await _fileStorageService.UploadFileAsync(updateDto.Image);
            }

            dbContext.Products.Update(productFromDb);
            await dbContext.SaveChangesAsync();
            
            return Ok(new ResponseServer(true, HttpStatusCode.OK, productFromDb));
            
        }
        catch (Exception ex)
        {
            return BadRequest(new ResponseServer(false, HttpStatusCode.BadRequest, null, ex.Message));
        }
    }

    [HttpDelete]
    public async Task<ActionResult<ResponseServer>> DeleteProduct(int id)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest(ResponseServer.CreateBadRequest("Неккоректный id"));
            }
            
            Product item = await dbContext.Products.FirstOrDefaultAsync(e => e.Id == id);
            if (item is null)
            {
                return NotFound(ResponseServer.CreateNotFound("Товар с указанным Id не найден"));
            }
            
            await _fileStorageService.RemoveFileAsync(item.Image.Split('/').Last());
            
            dbContext.Products.Remove(item);
            await dbContext.SaveChangesAsync();
            
            return Ok(new ResponseServer(true, HttpStatusCode.NoContent, null));
            
        }
        catch (Exception ex)
        {
            return BadRequest(ResponseServer.CreateBadRequest("Что-то пошло не так", ex.Message));
        }
    }
}