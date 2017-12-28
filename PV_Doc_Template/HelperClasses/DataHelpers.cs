using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PV_Doc_Template.HelperClasses
{
    public class DataHelpers
    {
        public DateTime GetBirthday(OCRRawDataModel.RawDataItem value)
        {
            DateTime date;
            var tempDate = value.Value.Replace("O", "0");
            var isValidDate = DateTime.TryParse(tempDate, out date);
            if (isValidDate && ((DateTime.Now.Year - date.Year) > 16))
            {
                return date;
            }
            return DateTime.MinValue;
        }

        public string GetState(OCRRawDataModel.RawDataItem value)
        {
            if (DataConstants.usStateAbbriviations.Contains(value.Value))
            {
                return value.Value;
            }
            return string.Empty;
        }

        public bool IsValidZip(string zipCode)
        {
            return Regex.IsMatch(zipCode, DataConstants.ValidZipCode);
        }

        public bool IsValidName(string name)
        {
            return Regex.IsMatch(name, DataConstants.ValidName);
        }

        public string cleanLastName(string value)
        {
            return Regex.Replace(value, @"[^a-zA-Z.]", string.Empty);
        }
        
        public string GetAddress(string address)
        {
            var googleApiKey = "AIzaSyAH7G0fIkN5AynY727DhCyajQisokxf9es";
            string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}", Uri.EscapeDataString(address), googleApiKey);
            var newAddress = string.Empty;

            using (var client = new HttpClient())
            {
                // HTTP POST
                client.BaseAddress = new Uri(requestUri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync("").Result;
                Result res = new Result();
                using (HttpContent content = response.Content)
                {
                    // ... Read the string.
                    Task<string> result = content.ReadAsStringAsync();
                    Rootobject obj = JsonConvert.DeserializeObject<Rootobject>(result.Result);

                    if (obj.status.Equals("ok", StringComparison.InvariantCultureIgnoreCase))
                    {
                        newAddress = obj.results[0].formatted_address;
                    }
                }
            }

            return newAddress;
        }
        
        public class Rootobject
        {
            public Result[] results { get; set; }
            public string status { get; set; }
        }

        public class Result
        {
            public string formatted_address { get; set; }
        }
    }
}
