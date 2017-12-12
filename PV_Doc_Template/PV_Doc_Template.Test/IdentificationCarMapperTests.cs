using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using PV_Doc_Template;

namespace PV_Doc_Template.Test
{
    [TestFixture()]
    public class IdentificationCardMapperTests
    {
        [Test]
        public void MapDriversLicenseDataTest()
        {
            var data = File.ReadAllText(@"c:\images\sample-drivers-license_100402877_m.json");
            var mapper = new IdentificationCardMapper();
            var results = mapper.MapDriversLicenseData(data);
            Assert.AreNotEqual(results, string.Empty);
        }
    }
}
