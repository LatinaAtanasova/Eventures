using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Eventures.Web.Utilities
{
    public class Seeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();
            var adminRoleExists = roleManager.RoleExistsAsync("Admin").Result;


            if (!adminRoleExists)
            {
                roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
            }
            
        }
        
    }
}
