using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template.HelperClasses
{
    public class DataHelpers
    {
        public DateTime GetBirthday(string value)
        {
            DateTime date;
            var isValidDate = DateTime.TryParse(value, out date);
            if (isValidDate && ((DateTime.Now.Year - date.Year) > 16))
            {
               return date;
            }
            return DateTime.MinValue;
        }

        public string GetState(string value)
        {
            if (DataConstants.usStates.Contains(value))
            {
                return value;
            }
            return string.Empty;
        }
    }
}
