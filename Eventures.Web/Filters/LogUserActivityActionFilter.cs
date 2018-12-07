using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Services.Eventures.Web.Services.EventuresEvents;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Filters
{
    public class LogUserActivityActionFilter : ActionFilterAttribute
    {
        private readonly IEventureEventService eventService;
        private readonly ILogger<LogUserActivityActionFilter> logger;

        public LogUserActivityActionFilter(IEventureEventService eventService, ILogger<LogUserActivityActionFilter> logger)
        {
            this.eventService = eventService;
            this.logger = logger;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var userName = context.HttpContext.User.Identity.Name;
            var eventureEvent = this.eventService.All().FirstOrDefault();
            var eventName = eventureEvent.Name;
            var eventStart = eventureEvent.Start;
            var eventEnd = eventureEvent.End;

            var logMessage = $"[{DateTime.Now}] User {userName} viewed event {eventName} ( {eventStart} / {eventEnd} )";
            logger.LogInformation(logMessage);


            //base.OnActionExecuting(context);
        }
    }
}
