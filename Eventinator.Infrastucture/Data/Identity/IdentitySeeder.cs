using Eventinator.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace Eventinator.Infrastructure.Data.Identity;

public static class IdentitySeeder
{
    private static readonly string[] Roles = ["SuperAdmin", "Organizer", "Attendee"];

    public static async Task SeedAsync(IServiceProvider services, ILogger logger)
    {
        using var scope = services.CreateScope();
        var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
        foreach (var roleName in Roles)
        {
            if (!await roleManager.RoleExistsAsync(roleName))
            {
                var result = await roleManager.CreateAsync(new ApplicationRole { Name = roleName });
                if (!result.Succeeded)
                {
                    logger.LogError("Failed creating role {Role}: {Errors}", roleName, string.Join(',', result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
