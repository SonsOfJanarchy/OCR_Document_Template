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
            if (data.Contains("DRIVER") && data.Contains("LICENSE"))
            {
                foreach (var word in data)
                {
                    var date = new DateTime();
                    DateTime.TryParse(word, out date);
                    if ((DateTime.Now.Year - date.Year) > 16)
                    {
                        var birthDate = date;
                    }
                }
                return "this is a NJ drivers license";
            }
            return "this is some sort of NJ identification";
        }
    }
}
