using Microsoft.AspNetCore.Identity;
using StoreApi.Common;

namespace StoreApi.Extensions;

public static class RoleInitializerService
{
    public static async Task InitializeRoleAsync(
        this IServiceProvider serviceProvider)
    {
        using var scope = serviceProvider.CreateScope();
        var roleManage = scope.ServiceProvider
            .GetRequiredService<RoleManager<IdentityRole>>();

        foreach (var role in SharedData.Roles.AllRoles)
        {
            if (!await roleManage.RoleExistsAsync(role))
            {
                await roleManage.CreateAsync(new IdentityRole(role));
            }
        }
    }
}