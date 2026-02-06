using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StoreApi.Common;
using StoreApi.Data;
using StoreApi.Model;

namespace StoreApi.Controllers;

[Route("api/[controller]/[action]")]
public class AuthTestController : StoreController
{
    public AuthTestController(AppDbContext dbContext) : base(dbContext)
    {
    }

    [HttpGet]
    public IActionResult Test1()
    {
        return Ok(new ResponseServer
        {
            StatusCode = HttpStatusCode.OK,
            Response = "Тест для всех пользователей"
        });
    }
    
    [HttpGet]
    [Authorize]
    public IActionResult Test2()
    {
        return Ok(new ResponseServer
        {
            StatusCode = HttpStatusCode.OK,
            Response = "Тест для авторизованных пользователей"
        });
    }
    
    [HttpGet]
    [Authorize(Roles = SharedData.Roles.Consumer)]
    public IActionResult Test3()
    {
        return Ok(new ResponseServer
        {
            StatusCode = HttpStatusCode.OK,
            Response = "Тест для Consumer пользователей"
        });
    }
    
    [HttpGet]
    [Authorize(Roles = SharedData.Roles.Admin)]
    public IActionResult Test4()
    {
        return Ok(new ResponseServer
        {
            StatusCode = HttpStatusCode.OK,
            Response = "Тест для Admin пользователей"
        });
    }
}