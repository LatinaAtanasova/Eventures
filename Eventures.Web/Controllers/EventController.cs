using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;
using Eventures.Web.ViewModels.Events;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace Eventures.Web.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventureEventService eventureEventService;
        private readonly UserManager<EventuresUser> userManager;
        private readonly IEventureOrderService orderService;


        public EventController(IEventureEventService eventureEventService, 
                                UserManager<EventuresUser> userManager,
                                IEventureOrderService orderService)
        {
            this.eventureEventService = eventureEventService;
            this.userManager = userManager;
            this.orderService = orderService;
        }

        public IActionResult All(int? page)
        {
            var events = eventureEventService.All()
                .Where(x => x.TotalTickets > 0)
                .Select(x => new EventViewModel
            {
                EventId = x.Id,
                End = x.End,
                Name = x.Name,
                Start = x.Start
            }).ToList();

            var pageNumber = page ?? 1;
            var onePageOfEvents = events.ToPagedList(pageNumber, 10);

            ViewBag.OnePageOfEvents = onePageOfEvents;
            return View();
        }

        public IActionResult CreateEvent()
        {

            return this.View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateEvent(CreateEventViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newEventToAdd = new Event()
                {
                    Name = model.Name,
                    End = model.End,
                    Place = model.Place,
                    PricePerTicket = model.PricePerTicket,
                    Start = model.Start,
                    TotalTickets = model.TotalTickets
                };

                eventureEventService.AddEvent(newEventToAdd);

                return this.RedirectToAction("All", "Event");
            }
            else
            {
                return this.View(model);
            }
        }


        public IActionResult MyEvents()
        {
            var userEvents = orderService.All()
                .Where(x => x.CustomerId == userManager.GetUserId(this.User))
                .ToList();

            
            if (userEvents == null)
            {
                return Content("No Events");
            }

            else
            {
                var myEvents = userEvents
                        .Select(x => new MyEventViewModel()
                {
                    End = x.Event.End,
                    Name = x.Event.Name,
                    Start = x.Event.Start,
                    Ticket = x.TicketsCount
                }).ToList();


                var userEventsCollection = new MyEventsViewModel()
                {
                    MyEvents = myEvents
                };

                return this.View(userEventsCollection);
            }
        }
    }
}