using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template
{
    public class OCRRawDataModel
    {
        public List<RawDataItem> DataList { get; set; } 

        public class RawDataItem 
        {
            public string Value { get; set; }
            public int LineIndex { get; set; }
        }
    }
}
