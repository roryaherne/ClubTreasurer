using ClubTreasurer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace ClubTreasurer.Data
{
    public class IdentitySeed
    {
        public static async Task Initialize(ClubTreasurerContext context,
                              UserManager<AppUser> userManager, IOptions<RCIConfig> rciConfig,
                              RoleManager<AppRole> roleManager, IConfiguration configuration)
        {
            context.Database.EnsureCreated();

            string adminRole = "Admin";
            string adminDescription = "This is the administrator role";

            var passwords = configuration.GetSection("Passwords");
            var adminPassword = passwords.GetValue<string>("AdminPassword");
            var adminEmail = rciConfig.Value.AdminEmailAddress;
            var adminFirstName = rciConfig.Value.AdminFirstName;
            var adminLastName = rciConfig.Value.AdminLastName; ;

            if (await roleManager.FindByNameAsync(adminRole) == null)
            {
                await roleManager.CreateAsync(new AppRole(adminRole, adminDescription, DateTime.Now));
            }
           

            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                var user = new AppUser
                {
                    UserName = $"{adminFirstName} {adminLastName} (Administrator)",
                    FirstName = adminFirstName,
                    LastName = adminLastName,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, adminPassword);
                    await userManager.AddToRoleAsync(user, adminRole);
                    await userManager.UpdateNormalizedEmailAsync(user);
                    await userManager.UpdateNormalizedUserNameAsync(user);
                }
            }
        }
    }
}
