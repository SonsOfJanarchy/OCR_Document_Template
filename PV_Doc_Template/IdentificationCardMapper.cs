using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV_Doc_Template.HelperClasses;
using PV_Doc_Template.IdentificationTemplates;

namespace PV_Doc_Template
{
    public class IdentificationCardMapper
    {
        public IndentificationReturnModel MapDriversLicenseData(string identificationData)
        {
            var data = DataConstants.JsonReplacePattern.Replace(identificationData, string.Empty);
            string[] words = data.Split(',');
            
            if (words.Any(word => word.Equals("NJ")))
            {
                var templateMapper = new NewJerseyTemplates();
                return templateMapper.MapDataToTemplate(words);
            }
            
            return new IndentificationReturnModel();
        }
    }
}
