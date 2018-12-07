using System;
using System.Collections.Generic;
using System.Text;
using Eventures.Models;

namespace Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts
{
    public interface IEventureOrderService
    {
        void AddOrder(Order newOrder);

        IList<Order> All();

        void UpdateTotalTicketCount(Event chosenEvent, int orderedTickets);
    }
}
