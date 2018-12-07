using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventures.Data.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;

namespace Eventures.Services.Eventures.Web.Services.EventuresEvents
{
    public class EventureOrderService : IEventureOrderService
    {
        private readonly EventuresDbContext dbContext;

        public EventureOrderService(EventuresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public void AddOrder(Order newOrder)
        {
            this.dbContext.Orders.Add(newOrder);
            this.dbContext.SaveChanges();
        }

        public IList<Order> All()
        {
            return this.dbContext.Orders.ToList();
        }

        public void UpdateTotalTicketCount(Event eventChosen, int orderedTickets)
        {
         
            eventChosen.TotalTickets = eventChosen.TotalTickets - orderedTickets;
            dbContext.SaveChanges();
        }
    }
}
