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
        public static string[] usStateAbbriviations =
        {
            "AL", "AK", "AS", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FM", "FL", "GA", "GU", "HI", "ID", "IL", "IN",
            "IA", "KS", "KY", "LA", "ME", "MH", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM",
            "NY", "NC", "ND", "MP", "OH", "OK", "OR", "PW", "PA", "PR", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VI",
            "VA", "WA", "WV", "WI", "WY"
        };

        public static string[] usStates =
        {
            "AL", "Alabama", "AK", "Alaska", "AZ", "Arizona", "AR","Arkansas", "CA","California", "CO", "Colorado", "CT","Connecticut",
            "DE", "Delaware", "DC", "District of Columbia", "FL","Florida", "GA","Georgia", "HI","Hawaii", "ID","Idaho", "IL","Illinois",
            "IN", "Indiana", "IA","Iowa", "KS","Kansas","KY","Kentucky","LA","Louisiana", "ME", "Maine","MD", "Maryland", "MA","Massachusetts",
            "MI", "Michigan", "MN", "Minnesota", "MS", "Minnesota", "MO","Missouri", "MT", "Montana", "NE", "Nebraska", "NV","Nevada",
            "NH", "New Hampshire", "NJ", "New Jersey", "NM", "New Mexico", "NY", "New York", "NC","North Carolina", "ND", "North Dakota",
            "OH", "Ohio","OK","Oklahoma", "OR", "Oregon", "PA","Pennsylvania", "RI","Rhode Island", "SC","South Carolina", "SD","South Dakota",
            "TN", "Tennessee", "TX", "Texas", "UT", "Utah", "VT", "Vermont", "VA", "Virginia", "WA", "Washington", "WV", "West Virginia",
            "WI", "Wisconsin", "WY", "Wyoming"
        };

        public static string[] fullStates =
        {
            "Alabama", "Arkansas", "Arizona", "California","Colorado","Connecticut","Delaware","District of Columbia", "Florida",
            "Georgia", "Hawaii", "Idaho","Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland",
            "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
            "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
            "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
            "West Virginia", "Wisconsin", "Wyoming"
        };

        public const string ValidZipCode = @"^[0 - 9]{5}((-)?([0-9]{5}))?$";
        public const string ValidName = @"^[a - zA - Z][a - zA - Z, '\-.]*$";
        public const string ValidData = @"^[a-zA-Z0-9\-. ]*$";
    }
}
