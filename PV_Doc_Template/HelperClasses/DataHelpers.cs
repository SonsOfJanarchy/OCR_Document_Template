using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template.HelperClasses
{
    public class DataHelpers
    {
        string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
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
            if (states.Contains(value))
            {
                return value;
            }
            return string.Empty;
        }
    }
}
