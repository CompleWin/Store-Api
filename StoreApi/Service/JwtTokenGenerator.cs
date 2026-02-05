using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using StoreApi.Model;

namespace StoreApi.Service;

public class JwtTokenGenerator
{

    private readonly string _secretKey;
    
    public JwtTokenGenerator(IConfiguration configuration)
    {
        _secretKey = configuration["AuthSettings:SecretKey"];
    }

    public string GenerateJwtToken(AppUser user, IList<string> roles)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_secretKey);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([
                new("FirstName", user.UserName),
                new("id", user.Id),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Role, string.Join(",", roles))
            ]),

            Expires = DateTime.UtcNow.AddDays(1),

            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature
            )
        };
        
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
    
}