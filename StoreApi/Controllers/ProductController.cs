using Microsoft.AspNetCore.Mvc;

namespace StoreApi.Controllers;

public class ProductController : StoreController
{
    [HttpGet]
    public async Task<ActionResult> Get()
    {
        return Ok(await Task.FromResult("hello world"));
    }
    
}