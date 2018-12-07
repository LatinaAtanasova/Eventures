using System;
using System.Collections.Generic;
using System.Text;

namespace Eventures.Models
{
    public class Event
    {
        public Event()
        {
            this.Orders = new HashSet<Order>();
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public string Place { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TotalTickets { get; set; }

        public decimal PricePerTicket { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
