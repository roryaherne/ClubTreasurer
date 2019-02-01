using ClubTreasurer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace ClubTreasurer.Data
{
    public class IdentitySeed
    {
        public static async Task Initialize(ClubTreasurerContext context,
                              UserManager<AppUser> userManager,
                              RoleManager<AppRole> roleManager, IConfiguration configuration)
        {
            context.Database.EnsureCreated();


            string adminRole = "Admin";
            string adminDescription = "This is the administrator role";

            var emailSettings = configuration.GetSection("EmailSettings");

            var passwords = configuration.GetSection("Passwords");
            var adminPassword = passwords.GetValue<string>("AdminPassword");

            if (await roleManager.FindByNameAsync(adminRole) == null)
            {
                await roleManager.CreateAsync(new AppRole(adminRole, adminDescription, DateTime.Now));
            }
           

            if (await userManager.FindByEmailAsync("roryaherne@gmail.com") == null)
            {
                var user = new AppUser
                {
                    UserName = "roryaherne@gmail.com",
                    FirstName = "Rory",
                    LastName = "Aherne",
                    Email = "roryaherne@gmail.com",
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
