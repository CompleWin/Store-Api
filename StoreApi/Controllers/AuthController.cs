using System.Net;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApi.Common;
using StoreApi.Data;
using StoreApi.Model;
using StoreApi.ModelDto;
using StoreApi.Service;

namespace StoreApi.Controllers;

[Route("api/[controller]/[action]")]
public class AuthController : StoreController
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly JwtTokenGenerator _jwtTokenGenerator;

    public AuthController(
        AppDbContext dbContext,
        UserManager<AppUser> userManager,
        RoleManager<IdentityRole> roleManager,
        JwtTokenGenerator jwtTokenGenerator
    ) : base(dbContext)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerDto)
    {
        if (registerDto is null)
        {
            return BadRequest(ResponseServer.CreateBadRequest("Ошибка регистрации"));
        }

        var existingEmail = await dbContext.AppUsers.FirstOrDefaultAsync(a => a.Email == registerDto.Email);
        if (existingEmail is not null)
        {
            return BadRequest(ResponseServer.CreateBadRequest("Пользователь с таким Email уже существует!"));
        }

        var existingUserName = await dbContext.AppUsers.FirstOrDefaultAsync(a => a.UserName == registerDto.UserName);
        if (existingUserName is not null)
        {
            return BadRequest(ResponseServer.CreateBadRequest("Пользователь с таким Username уже сущесвует!"));
        }

        AppUser user = new()
        {
            UserName = registerDto.UserName,
            Email = registerDto.Email
        };

        var result = await _userManager.CreateAsync(user, registerDto.Password);

        if (!result.Succeeded)
        {
            return BadRequest(ResponseServer.CreateBadRequest(result
                .Errors
                .Select(e => e.Description)
                .ToArray()));
        }

        var userRole = registerDto.Role.Equals(SharedData.Roles.Admin,
            StringComparison.OrdinalIgnoreCase)
            ? SharedData.Roles.Admin
            : SharedData.Roles.Consumer;

        await _userManager.AddToRoleAsync(user, userRole);

        return Ok(new ResponseServer(true, HttpStatusCode.OK, null));
    }

    [HttpPost]
    public async Task<ActionResult<ResponseServer>> Login(
        [FromBody] LoginRequestDto loginDto)
    {
        var userFromDb = dbContext
            .AppUsers
            .FirstOrDefault(u => u.Email.ToLower() == loginDto.Email.ToLower());

        if (userFromDb is null 
            || !await _userManager.CheckPasswordAsync(userFromDb, loginDto.Password))
        {
            return BadRequest(ResponseServer.CreateBadRequest("Такого пользователя не сущесвует или неверный пароль!"));
        }
        
        var roles = await  _userManager.GetRolesAsync(userFromDb);
        var token = _jwtTokenGenerator.GenerateJwtToken(userFromDb, roles);

        var responseDto = new LoginResponseDto
        {
            Email = userFromDb.Email,
            Token = token
        };
        
        return Ok(new ResponseServer(true, HttpStatusCode.OK, responseDto));
        
    }
}