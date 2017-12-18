using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV_Doc_Template.HelperClasses;

namespace PV_Doc_Template.IdentificationTemplates
{
    public class NewMexicoTemplates
    {
        public IdentificationReturnModel MapDataToTemplate(List<OCRRawDataModel.RawDataItem> data)
        {
            var dataHelper = new DataHelpers();
            var model = new IdentificationReturnModel();
            StringBuilder addressStringBuilder = new StringBuilder();
            StringBuilder lastNameStringBuilder = new StringBuilder();

            var containsStuff = data.Any(v => v.Value.Contains("DRIVER")) && data.Any(v => v.Value.Contains("LICENSE"));
            if (containsStuff)
            {
                foreach (var item in data)
                {
                    //Get Birthday
                    var birthDate = dataHelper.GetBirthday(item);
                    if (birthDate != DateTime.MinValue)
                    {
                        model.dateofBirth = birthDate;
                    }
                    //Get state
                    var state = dataHelper.GetState(item);
                    if (!string.IsNullOrWhiteSpace(state))
                    {
                        model.state = item.Value;
                        var zipIndex = data.FindIndex(a => a.Value.Equals(item.Value)) + 1;
                        model.zip = data[zipIndex].Value;
                    }
                    //Get city

                    //Build Address

                    if (item.LineIndex == 6)
                    {
                        addressStringBuilder.Append(item.Value.Trim()).Append(" ");
                        model.address1 = addressStringBuilder.ToString().TrimEnd();
                    }

                    //Get LastName using the line index, which should always be the 4th line
                    if (item.LineIndex == 4)
                    {
                        lastNameStringBuilder.Append(item.Value.Trim()).Append(" ");
                        model.lastName = lastNameStringBuilder.ToString().TrimEnd();
                    }

                    //Get FirstName and middle name
                    if (item.LineIndex == 5)
                    {
                        model.firstName = string.IsNullOrWhiteSpace(model.firstName) ? item.Value : model.firstName;
                        //Assuming the the middle name comes after the first name, this may not be true, but we don't have a better way to get it yet.
                        if (!string.IsNullOrWhiteSpace(model.firstName))
                        {
                            var middleNameIndex = data.FindIndex(a => a.Value.Equals(model.firstName)) + 1;
                            model.middleName = data[middleNameIndex].Value;
                        }
                    }
                }
            }
            model.DataLength = model.ToString().Length;
            return model;
        }
    }
}
