using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template.IdentificationTemplates
{
    public class NewJerseyTemplates
    {
        public string MapDataToTemplate(string[] data)
        {
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            if (data.Contains("DRIVER") && data.Contains("LICENSE"))
            {
                foreach (var word in data)
                {
                    DateTime date;
                    var isValidDate = DateTime.TryParse(word, out date);
                    if (isValidDate && ((DateTime.Now.Year - date.Year) > 16))
                    {
                        var birthDate = date;
                    }
                    if (states.Contains(word))
                    {
                        var state = word;
                    }
                }
                return "this is a NJ drivers license";
            }
            return "this is some sort of NJ identification";
        }
    }
}
