using Microsoft.AspNetCore.Mvc;
using StoreApi.Data;

namespace StoreApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoreController : ControllerBase
{
    protected readonly AppDbContext dbContext;

    public StoreController(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
}