using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventures.Data.Data;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts;

namespace Eventures.Services.Eventures.Web.Services.EventuresEvents
{
    public class EventureEventService : IEventureEventService
    {
        private readonly EventuresDbContext context;

        public EventureEventService(EventuresDbContext context)
        {
            this.context = context;
        }

        public IList<Event> All() => this.context.Events.ToList();

        public void AddEvent(Event newEvent)
        {
            this.context.Events.Add(newEvent);
            this.context.SaveChanges();
        }
    }
}
