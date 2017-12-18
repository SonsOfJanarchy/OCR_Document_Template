using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template
{
    public class IdentificationReturnModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string sex { get; set; }
        public DateTime dateofBirth { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string fullAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string[] indentificationImage { get; set; }
        public int DataLength { get; set; }
    }
}
