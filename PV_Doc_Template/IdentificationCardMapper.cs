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
        public IdentificationReturnModel MapDriversLicenseData(OCRRawDataModel identificationData)
        {
            foreach (var items in identificationData.DataList)
            {
                if (items.Value.Equals("NJ", StringComparison.InvariantCultureIgnoreCase))
                {
                    var templateMapper = new NewJerseyTemplates();
                    return templateMapper.MapDataToTemplate(identificationData.DataList);
                }
            }

            return new IdentificationReturnModel();
        }
    }
}
