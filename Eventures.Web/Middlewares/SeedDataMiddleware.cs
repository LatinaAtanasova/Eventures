using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data.Data;
using Eventures.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Eventures.Web.Middlewares
{
    public class SeedDataMiddleware
    {
        private readonly RequestDelegate next;

        public SeedDataMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync
                        (HttpContext context, 
                        EventuresDbContext dbContext, 
                        UserManager<EventuresUser> userManager,
                        RoleManager<IdentityRole> roleManager)
        {
            if (!dbContext.Events.Any())
            {
                this.SeedEvents(dbContext);
            }

            if (!dbContext.Roles.Any())
            {
                await this.SeedRoles(userManager, roleManager);
            }

            await this.next(context);
        }

        private async Task SeedRoles
                        (UserManager<EventuresUser> userManager, 
                        RoleManager<IdentityRole> roleManager)
        {
            var result = await roleManager.CreateAsync(new IdentityRole("Admin"));
            var resultUserRole = await roleManager.CreateAsync(new IdentityRole("User"));

            if (result.Succeeded && userManager.Users.Any())
            {
                var firstUser = userManager.Users.FirstOrDefault();
                await userManager.AddToRoleAsync(firstUser, "Admin");
            }

        }

        private void SeedEvents(EventuresDbContext context)
        {
            var sampleEvents = new List<Event>();

            for (int i = 1; i <= 10; i++)
            {
                var sampleEvent = new Event()
                {
                    Name = $"Sample event = {i}",
                    Place = $"Sample place address 100{i}",
                    Start = DateTime.Now.Add(TimeSpan.FromDays(i)),
                    End = DateTime.Now.Add(TimeSpan.FromDays(i + 10)),
                    PricePerTicket = 10 + i,
                    TotalTickets = 100*i
                };

                sampleEvents.Add(sampleEvent);
               
            }

            context.Events.AddRange(sampleEvents);
            context.SaveChanges();
        }
    }
}
