using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Web.Validations
{
    public class ValidDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = false;
            if (value is DateTime)
            {
                if ((DateTime)value >= DateTime.UtcNow)
                {
                    return isValid = true;
                }
            }
            else
            {
                DateTime dt;
                DateTime.TryParseExact(value.ToString(),
                    "yyyy-dd-MM hh:mm tt",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out dt);

                if (dt >= DateTime.UtcNow)
                {
                    return isValid = true;
                }
            }

            return isValid;
        }
    }
}
