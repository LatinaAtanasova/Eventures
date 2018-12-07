using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.ViewModels.Orders
{
    public class OrderViewModel
    {
        public string EventName { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
