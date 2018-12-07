using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Web.Validations;

namespace Eventures.Web.ViewModels.Events
{
    public class EventViewModel
    {
        public string EventId { get; set; }

        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Ticket { get; set; }

       public DateTime Start { get; set; }

        public DateTime End { get; set; }

    }
}
