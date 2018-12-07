using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.ViewModels.Events
{
    public class MyEventsViewModel
    {
        public ICollection<MyEventViewModel> MyEvents { get; set; }
    }
}
