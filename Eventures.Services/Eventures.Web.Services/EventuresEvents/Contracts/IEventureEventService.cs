using Eventures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventures.Services.Eventures.Web.Services.EventuresEvents.Contracts
{
    public interface IEventureEventService
    {
        IList<Event> All();

        void AddEvent(Event newEvent);
    }
}
