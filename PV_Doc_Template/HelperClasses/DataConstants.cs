using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PV_Doc_Template.HelperClasses
{
    public class DataConstants
    {
        public static string[] usStates =
        {
            "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY",
            "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH",
            "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY"
        };

        public const string ValidZipCode = @"^[0 - 9]{5}((-)?([0-9]{5}))?$";
        public const string ValidName = @"^[a - zA - Z][a - zA - Z, '\-.]*$";
        public const string ValidData = @"^[a-zA-Z0-9\-. ]*$";
    }
}
