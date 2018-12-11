using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventures.Data.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Eventures.Tests
{
    public class EventureOrderServiceTest
    {
        [Fact]
        public void ReturnsAllOrders()
        {
            var options = new DbContextOptionsBuilder<EventuresDbContext>()
                .UseInMemoryDatabase(databaseName: "Find_EventureUser_Database") // Give a Unique name to the DB
                .Options;

            var count = 0;

            using (var dbContext = new EventuresDbContext(options)) // Initialize Testing Data
            {

                var service = new EventureOrderService(dbContext);
                dbContext.Events.Add(new Event
                {
                    End = DateTime.UtcNow.AddDays(8),
                    Name = "TestEvent",
                    Start = DateTime.UtcNow,
                    TotalTickets = 10
                });
                dbContext.SaveChanges();
                var user1 = new EventuresUser
                {
                    UserName = "Pesho",
                    Email = "pesho@peshi.com"
                };

                var event1 = dbContext.Events.FirstOrDefault(x => x.Name == "TestEvent");

                var order = new Order
                {
                    Customer = user1,
                    CustomerId = user1.Id,
                    Event = event1,
                    EventId = event1.Id,
                    OrderedOn = DateTime.UtcNow,
                    TicketsCount = 3
                };
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();


                count = service.All().Count;

            }
            Assert.Equal(1, count);
        }

        

    }
}
