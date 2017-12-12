using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PV_Doc_Template
{
    public class IndentificationReturnModel
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string middleName { get; set; }
        private string sex { get; set; }
        private DateTime dateofBirth { get; set; }
        private string address1 { get; set; }
        private string address2 { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zip { get; set; }
        private string indentificationImage { get; set; }
    }
}
