﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template.HelperClasses
{
    public class DataHelpers
    {
        public DateTime GetBirthday(OCRRawDataModel.RawDataItem value)
        {
            DateTime date;
            var isValidDate = DateTime.TryParse(value.Value, out date);
            if (isValidDate && ((DateTime.Now.Year - date.Year) > 16))
            {
               return date;
            }
            return DateTime.MinValue;
        }

        public string GetState(OCRRawDataModel.RawDataItem value)
        {
            if (DataConstants.usStates.Contains(value.Value))
            {
                return value.Value;
            }
            return string.Empty;
        }
    }
}
