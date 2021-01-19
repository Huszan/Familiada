using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada
{
    public static class SeedData
    {
        public static void Seed(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }
        private static void SeedUsers(UserManager<IdentityUser> userManager)
        {
            if (userManager.FindByNameAsync("admin").Result == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@localhost"
                };
                var result = userManager.CreateAsync(user, "P@ssw0rd").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator");
                }
            }
        }
        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                roleManager.CreateAsync(role);
            }
            if (!roleManager.RoleExistsAsync("Player").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Player"
                };
                roleManager.CreateAsync(role);
            }
        }
    }
}
