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

            #region create DataList
            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NEW",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "JERSEY",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "'\"",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "AUTO",
                LineIndex = 0
            });

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
                Value = "....",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value ="{gg}",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "x9000",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "99090",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "90909",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "D",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "···",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "mm",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "05-20-1956",
                LineIndex = 1
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "BOAT",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "05-20-2010",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "c><~",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "05-20-2014",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "LAST",
                LineIndex = 4
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NAME",
                LineIndex = 4
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "SUFIX",
                LineIndex = 4
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "FIRST",
                LineIndex = 5
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "MIDDLE",
                LineIndex = 5
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "123",
                LineIndex = 6
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NORTH",
                LineIndex = 6
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "STATE",
                LineIndex = 6
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "STREET",
                LineIndex = 6
            });
            
            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "TRENTON",
                LineIndex = 7
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NJ",
                LineIndex = 7
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "08655-1234",
                LineIndex = 7
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "um",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NONE",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "¥",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "num",
                LineIndex = 0
            });

            data.DataList.Add(new OCRRawDataModel.RawDataItem
            {
                Value = "NONE",
                LineIndex = 0
            });
            #endregion create DataList

            var mapper = new IdentificationCardMapper();
            var results = mapper.MapDriversLicenseData(data);

            Assert.AreNotEqual(results, string.Empty);
        }
    }
}
