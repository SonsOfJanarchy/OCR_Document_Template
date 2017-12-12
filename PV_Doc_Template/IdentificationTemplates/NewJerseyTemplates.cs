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
        public IdentificationReturnModel MapDataToTemplate(string[] data)
        {
            var dataHelper = new DataHelpers();
            var model = new IdentificationReturnModel();

            if (data.Contains("DRIVER") && data.Contains("LICENSE"))
            {
                foreach (var item in data)
                {
                    var birthDate = dataHelper.GetBirthday(item);
                    if (birthDate != null)
                    {
                        model.dateofBirth = birthDate;
                    }
                    var state = dataHelper.GetState(item);
                    if (!string.IsNullOrWhiteSpace(state))
                    {
                        model.state = item;
                        var zipIndex = Array.IndexOf(data, item) + 1;
                        model.zip = data[zipIndex];
                    }
                }
            }
            return model;
        }
    }
}
