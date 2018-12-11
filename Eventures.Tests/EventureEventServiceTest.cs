using System;
using Eventures.Data.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Eventures.Tests
{
    public class EventureEventServiceTest
    {
        [Fact]
        public void ReturnsAllEvents()
        {
            var options = new DbContextOptionsBuilder<EventuresDbContext>()
                .UseInMemoryDatabase(databaseName: "Find_EventureUser_Database") // Give a Unique name to the DB
                .Options;

            var count = 0;
            using (var dbContext = new EventuresDbContext(options)) // Initialize Testing Data
            {
                dbContext.Events.AddRange(GetTestData());
                dbContext.SaveChanges();

                var service = new EventureEventService(dbContext);
                count = service.All().Count;

            }
            Assert.Equal(4, count);
        }

        private Event[] GetTestData()
        {
            Event[] sampleEvents =
            {
                new Event
                {
                    End = DateTime.UtcNow.AddDays(6),
                    Name = "Masqarade",
                    Start = DateTime.UtcNow
                },
                new Event
                {
                    End = DateTime.UtcNow.AddDays(8),
                    Name = "SayHi",
                    Start = DateTime.UtcNow.AddDays(2)
                },
                new Event
                {
                    End = DateTime.UtcNow.AddDays(10),
                    Name = "JustParty",
                    Start = DateTime.UtcNow.AddDays(3)
                }
            };
            return sampleEvents;
        }
    }
}
