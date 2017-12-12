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
        public IdentificationReturnModel MapDataToTemplate(List<OCRRawDataModel.RawDataItem> data)
        {
            var dataHelper = new DataHelpers();
            var model = new IdentificationReturnModel();

            var containsStuff = data.Any(v => v.Value.Contains("DRIVER")) && data.Any(v=>v.Value.Contains("LICENSE"));
            if (containsStuff)
            {
                foreach (var item in data)
                {
                    var birthDate = dataHelper.GetBirthday(item);
                    if (birthDate != DateTime.MinValue)
                    {
                        model.dateofBirth = birthDate;
                    }
                    var state = dataHelper.GetState(item);
                    if (!string.IsNullOrWhiteSpace(state))
                    {
                        model.state = item.Value;
                        var zipIndex = data.FindIndex(a=> a.Value.Equals(item.Value)) + 1;
                        model.zip = data[zipIndex].Value;
                    }
                }
            }
            return model;
        }
    }
}
