using Microsoft.AspNetCore.Identity;

namespace StoreApi.Model;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; }
}