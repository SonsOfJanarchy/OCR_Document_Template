using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using PV_Doc_Template.HelperClasses;

namespace PV_Doc_Template.IdentificationTemplates
{
    public class NewJerseyTemplates
    {
        public string MapDataToTemplate(string[] data)
        {
            var dataHelper = new DataHelpers();

            if (data.Contains("DRIVER") && data.Contains("LICENSE"))
            {
                var model = new IndentificationReturnModel();
                foreach (var item in data)
                {
                    var birthDate = dataHelper.GetBirthday(item);
                    if (birthDate != null)
                    {
                        var date = birthDate;
                    }
                    var state = dataHelper.GetState(item);
                    if (!String.IsNullOrWhiteSpace(state))
                    {
                        state = item;
                        var zipIndex = Array.IndexOf(data, item) + 1;
                        var zip = data[zipIndex];
                    }
                }
                return "this is a NJ drivers license";
            }
            return "this is some sort of NJ identification";
        }
    }
}
