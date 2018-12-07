using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;
using Eventures.Web.Models;
using Eventures.Web.ViewModels;
using Eventures.Web.ViewModels.Events;
using Eventures.Web.ViewModels.Orders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<EventuresUser> userManager;
        private readonly IEventureOrderService orderService;
        private readonly EventuresDbContext dbContext;

        public OrderController(UserManager<EventuresUser> userManager, 
                               IEventureOrderService orderService,
                               EventuresDbContext dbContext)
        {
            this.userManager = userManager;
            this.orderService = orderService;
            this.dbContext = dbContext;
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CreateOrderViewModel model)
        {
            if (ModelState.IsValid)
            {

                Event eventChosen = dbContext.Events.First(x => x.Id == model.EventId);

                if (eventChosen.TotalTickets < model.TicketsCount)
                {
                    var error = new ErrorMessageViewModel
                    {
                        ErrorMessage = "Less available tickets than ordered!"
                    };
                    return this.RedirectToAction("Index", "Error", error);
                }


                var customerId = userManager.GetUserId(this.User);
                var customer = dbContext.EventuresUsers.First(x => x.Id == customerId);
                var newOrder = new Order()
                {
                    Customer = customer,
                    Event = eventChosen,
                    CustomerId = customerId,
                    EventId = model.EventId,
                    OrderedOn = DateTime.UtcNow,
                    TicketsCount = model.TicketsCount
                };

                this.orderService.AddOrder(newOrder);

                orderService.UpdateTotalTicketCount(eventChosen, newOrder.TicketsCount);


                return this.RedirectToAction("MyEvents", "Event");

            }

            return this.RedirectToAction("All", "Event");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult All()
        {
            var allOrders = orderService.All().Select(x => new OrderViewModel()
            {
                CustomerName = x.Customer.FirstName,
                EventName = x.Event.Name,
                OrderedOn = x.OrderedOn
            }).ToList();

            return this.View(allOrders);
        }

    }
}