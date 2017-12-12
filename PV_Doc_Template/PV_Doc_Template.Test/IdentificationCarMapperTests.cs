using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using PV_Doc_Template;

namespace PV_Doc_Template.Test
{
    [TestFixture()]
    public class IdentificationCardMapperTests
    {
        [Test]
        public void MapDriversLicenseDataTest()
        {
            var data = new OCRRawDataModel {DataList = new List<OCRRawDataModel.RawDataItem>()};

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "DRIVER",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "LICENSE",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NJ",
                LineIndex = 1
            });
            
            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "04/15/1988",
                LineIndex = 1
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "61111",
                LineIndex = 1
            });

            var mapper = new IdentificationCardMapper();
            var results = mapper.MapDriversLicenseData(data);
            Assert.AreNotEqual(results, string.Empty);
        }
    }
}
