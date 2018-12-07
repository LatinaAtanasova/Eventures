using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;
using Eventures.Web.Areas.Event.ViewModels;
using Eventures.Web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Areas.Event.Controllers
{
    [Area("Event")]
    public class EventsController : Controller
    {

        private readonly IEventureEventService eventureEventService;

        public EventsController(IEventureEventService eventureEventService)
        {
            this.eventureEventService = eventureEventService;
        }

        [ServiceFilter(typeof(LogUserActivityActionFilter))]
        public IActionResult Index()
        {
;            return this.View();
        }


        public IActionResult All()
        {
            return this.View();
        }

        public IActionResult CreateEvent()
        {
            return this.View();
        }
    }
}