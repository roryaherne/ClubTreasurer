using ClubTreasurer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClubTreasurer.Data
{
    public class IdentitySeed
    {
        public static async Task Initialize(ClubTreasurerContext context,
                              UserManager<AppUser> userManager,
                              RoleManager<AppRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string adminRole = "Admin";
            string adminDescription = "This is the administrator role";

            string financesRole = "Finances";
            string financesDescription = "Can view payments";

            string adminPassword = "Ariapro21989!";
            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(adminRole) == null)
            {
                await roleManager.CreateAsync(new AppRole(adminRole, adminDescription, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(financesRole) == null)
            {
                await roleManager.CreateAsync(new AppRole(financesRole, financesDescription, DateTime.Now));
            }

            if (await userManager.FindByNameAsync("admin") == null)
            {
                var user = new AppUser
                {
                    UserName = "admin",
                    Email = "roryaherne@gmail.com",                   
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, adminPassword);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("jer") == null)
            {
                var user = new AppUser
                {
                    UserName = "jer",
                    Email = "jer.dejean@gmail.com",
                    FirstName = "Jeremie",
                    LastName = "DeJean"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, adminRole);
                }
                adminId2 = user.Id;
            }            
        }
    }
}
