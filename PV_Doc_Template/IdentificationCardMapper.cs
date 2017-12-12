using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV_Doc_Template.IdentificationTemplates;

namespace PV_Doc_Template
{
    public class IdentificationCardMapper
    {
        public string MapDriversLicenseData(string identificationData)
        {
            var data = identificationData.Replace("[", string.Empty).Replace("]", string.Empty).Replace("\"", string.Empty);
            string[] words = data.Split(',');
            string[] states = {"NJ", "IL"};
            foreach (var word in words)
            {
                if (word.Equals("NJ"))
                {
                    var templateMapper = new NewJerseyTemplates();
                    return templateMapper.MapDataToTemplate(words);
                }
            }
            
            //switch (licenseData)
            //{
            //    case "NY":
            //    {
            //        return "thing";
            //    }
            //}
            return "";
        }
    }
}
