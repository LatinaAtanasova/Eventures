using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Web.Validations;

namespace Eventures.Web.ViewModels.Events
{
    public class CreateEventViewModel
    {
        [Required, MinLength(10)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Place { get; set; }

        [Required]
        [ValidDate]
        public DateTime Start { get; set; }

        [Required]
        [ValidDate]
        public DateTime End { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int TotalTickets { get; set; }

        [Required]
        [Range(0.01, 79228162514264337593543950335d)]
        public decimal PricePerTicket { get; set; }
    }
}
