using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;
using Eventures.Web.Areas.Event.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Areas.Event.Components
{
    public class EventsComponent : ViewComponent
    {
        private readonly IEventureEventService eventureEventService;

        public EventsComponent(IEventureEventService eventureEventService)
        {
            this.eventureEventService = eventureEventService;
        }

        public IViewComponentResult Invoke()
        {
            var events = this.eventureEventService.All();
            var viewList = new List<EventureEventViewModel>();
            foreach (var item in events)
            {
                var model = new EventureEventViewModel()
                {
                    Name = item.Name,
                    End = item.End,
                    Place = item.Place,
                    PricePerTicket = item.PricePerTicket,
                    Start = item.Start,
                    TotalTickets = item.TotalTickets
                };
                viewList.Add(model);
            }
            return this.View(viewList);
        }
    }
}
