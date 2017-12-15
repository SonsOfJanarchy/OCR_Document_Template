using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PV_Doc_Template.HelperClasses;
using PV_Doc_Template.IdentificationTemplates;

namespace PV_Doc_Template
{
    public class IdentificationCardMapper
    {
        public IdentificationReturnModel MapDriversLicenseData(OCRRawDataModel identificationData)
        {
            var returnIndentification = new IdentificationReturnModel();
            var sentState = identificationData.DataList.Single(s => DataConstants.usStates.Contains(s.Value)).Value;
            
            switch (sentState.ToUpper())
            {
                case "AL":
                    var alTemplateMapper = new AlabamaTemplates();
                    returnIndentification = alTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ALABAMA":
                    var alabamaTemplateMapper = new AlabamaTemplates();
                    returnIndentification = alabamaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "AK":
                    var akTemplateMapper = new AlaskaTemplates();
                    returnIndentification = akTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ALASKA":
                    var alaskaTemplateMapper = new AlaskaTemplates();
                    returnIndentification = alaskaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "AZ":
                    var azTemplateMapper = new ArizonaTemplates();
                    returnIndentification = azTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ARIZONA":
                    var arizonaTemplateMapper = new ArizonaTemplates();
                    returnIndentification = arizonaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "AR":
                    var arTemplateMapper = new ArkansasTemplates();
                    returnIndentification = arTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ARKANSAS":
                    var arkansasTemplateMapper = new ArkansasTemplates();
                    returnIndentification = arkansasTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "CA":
                    var caTemplateMapper = new CaliforniaTemplates();
                    returnIndentification = caTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "CALIFORNIA":
                    var californiaTemplateMapper = new CaliforniaTemplates();
                    returnIndentification = californiaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "CO":
                    var coTemplateMapper = new ColoradoTemplates();
                    returnIndentification = coTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "COLORADO":
                    var coloradoTemplateMapper = new ColoradoTemplates();
                    returnIndentification = coloradoTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "CT":
                    var ctTemplateMapper = new ConnecticutTemplates();
                    returnIndentification = ctTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "CONNECTICUT":
                    var connecticutTemplateMapper = new ConnecticutTemplates();
                    returnIndentification = connecticutTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "DE":
                    var deTemplateMapper = new DelawareTemplates();
                    returnIndentification = deTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "DELAWARE":
                    var delawareTemplateMapper = new DelawareTemplates();
                    returnIndentification = delawareTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "DC":
                    var dcTemplateMapper = new DistrictOfColumbiaTemplates();
                    returnIndentification = dcTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "District of Columbia":
                    var districtofcolumbiaTemplateMapper = new DistrictOfColumbiaTemplates();
                    returnIndentification = districtofcolumbiaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "FL":
                    var flTemplateMapper = new FloridaTemplates();
                    returnIndentification = flTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "FLORIDA":
                    var floridaTemplateMapper = new FloridaTemplates();
                    returnIndentification = floridaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "GA":
                    var gaTemplateMapper = new GeorgiaTemplates();
                    returnIndentification = gaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "GEORGIA":
                    var georgiaTemplateMapper = new GeorgiaTemplates();
                    returnIndentification = georgiaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "HI":
                    var hiTemplateMapper = new HawaiiTemplates();
                    returnIndentification = hiTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "HAWAII":
                    var hawaiiTemplateMapper = new HawaiiTemplates();
                    returnIndentification = hawaiiTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ID":
                    var idTemplateMapper = new IdahoTemplates();
                    returnIndentification = idTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "IDAHO":
                    var idahoTemplateMapper = new IdahoTemplates();
                    returnIndentification = idahoTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "IL":
                    var ilTemplateMapper = new IllinoisTemplates();
                    returnIndentification = ilTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ILLINOIS":
                    var illinoisTemplateMapper = new IllinoisTemplates();
                    returnIndentification = illinoisTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "IN":
                    var inTemplateMapper = new IndianaTemplates();
                    returnIndentification = inTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "INDIANA":
                    var indianaTemplateMapper = new IndianaTemplates();
                    returnIndentification = indianaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "IA":
                    var iaTemplateMapper = new IowaTemplates();
                    returnIndentification = iaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "IOWA":
                    var iowaTemplateMapper = new IowaTemplates();
                    returnIndentification = iowaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "KS":
                    var ksTemplateMapper = new KansasTemplates();
                    returnIndentification = ksTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "KANSAS":
                    var kansasTemplateMapper = new KansasTemplates();
                    returnIndentification = kansasTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "KY":
                    var kyTemplateMapper = new KentuckyTemplates();
                    returnIndentification = kyTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "KENTUCKY":
                    var kentuckyTemplateMapper = new KentuckyTemplates();
                    returnIndentification = kentuckyTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "LA":
                    var laTemplateMapper = new LouisianaTemplates();
                    returnIndentification = laTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "LOUISIANA":
                    var louisianaTemplateMapper = new LouisianaTemplates();
                    returnIndentification = louisianaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ME":
                    var meTemplateMapper = new MaineTemplates();
                    returnIndentification = meTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MAINE":
                    var maineTemplateMapper = new MaineTemplates();
                    returnIndentification = maineTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MD":
                    var mdTemplateMapper = new MarylandTemplates();
                    returnIndentification = mdTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MARYLAND":
                    var marydTemplateMapper = new MarylandTemplates();
                    returnIndentification = marydTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MA":
                    var maTemplateMapper = new MassachusettsTemplates();
                    returnIndentification = maTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MASSACHUSETTS":
                    var massTemplateMapper = new MassachusettsTemplates();
                    returnIndentification = massTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MI":
                    var miTemplateMapper = new MichiganTemplates();
                    returnIndentification = miTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MICHIGAN":
                    var michTemplateMapper = new MichiganTemplates();
                    returnIndentification = michTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MN":
                    var mnTemplateMapper = new MinnesotaTemplates();
                    returnIndentification = mnTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MINNESOTA":
                    var minnTemplateMapper = new MinnesotaTemplates();
                    returnIndentification = minnTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MS":
                    var msTemplateMapper = new MississippiTemplates();
                    returnIndentification = msTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MISSISSIPPI":
                    var missTemplateMapper = new MississippiTemplates();
                    returnIndentification = missTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MO":
                    var moTemplateMapper = new MissouriTemplates();
                    returnIndentification = moTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MISSOURI":
                    var missoTemplateMapper = new MissouriTemplates();
                    returnIndentification = missoTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MT":
                    var mtTemplateMapper = new MontanaTemplates();
                    returnIndentification = mtTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "MONTANA":
                    var montTemplateMapper = new MontanaTemplates();
                    returnIndentification = montTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NE":
                    var neTemplateMapper = new NewEnglandTemplates();
                    returnIndentification = neTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NEBRASKA":
                    var nebTemplateMapper = new NewEnglandTemplates();
                    returnIndentification = nebTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NV":
                    var nvTemplateMapper = new NevadaTemplates();
                    returnIndentification = nvTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NEVADA":
                    var nevTemplateMapper = new NevadaTemplates();
                    returnIndentification = nevTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NH":
                    var nhTemplateMapper = new NewHampshireTemplates();
                    returnIndentification = nhTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "New Hampshire":
                    var newhampTemplateMapper = new NewHampshireTemplates();
                    returnIndentification = newhampTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NJ":
                    var njtemplateMapper = new NewJerseyTemplates();
                    returnIndentification = njtemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "New Jersey":
                    var newjtemplateMapper = new NewJerseyTemplates();
                    returnIndentification = newjtemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NM":
                    var nmTemplateMapper = new NewMexicoTemplates();
                    returnIndentification = nmTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "New Mexico":
                    var newmTemplateMapper = new NewMexicoTemplates();
                    returnIndentification = newmTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NY":
                    var nyTemplateMapper = new NewYorkTemplates();
                    returnIndentification = nyTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "New York":
                    var newyTemplateMapper = new NewYorkTemplates();
                    returnIndentification = newyTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "NC":
                    var ncTemplateMapper = new NorthCarolinaTemplates();
                    returnIndentification = ncTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "North Carolina":
                    var northcTemplateMapper = new NorthCarolinaTemplates();
                    returnIndentification = northcTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "ND":
                    var ndTemplateMapper = new NorthDakotaTemplates();
                    returnIndentification = ndTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "North Dakota":
                    var northdTemplateMapper = new NorthDakotaTemplates();
                    returnIndentification = northdTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "OH":
                    var ohTemplateMapper = new OhioTemplates();
                    returnIndentification = ohTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "OHIO":
                    var ohioTemplateMapper = new OhioTemplates();
                    returnIndentification = ohioTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "OK":
                    var okTemplateMapper = new OklahomaTemplates();
                    returnIndentification = okTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "OKLAHOMA":
                    var oklaTemplateMapper = new OklahomaTemplates();
                    returnIndentification = oklaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "OR":
                    var orTemplateMapper = new OregonTemplates();
                    returnIndentification = orTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "OREGON":
                    var oregonTemplateMapper = new OregonTemplates();
                    returnIndentification = oregonTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "PA":
                    var paTemplateMapper = new ArizonaTemplates();
                    returnIndentification = paTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "PENNSYLVANIA":
                    var pennTemplateMapper = new ArizonaTemplates();
                    returnIndentification = pennTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "RI":
                    var riTemplateMapper = new RhodeIslandTemplates();
                    returnIndentification = riTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "RHODE ISLAND":
                    var rhodeTemplateMapper = new RhodeIslandTemplates();
                    returnIndentification = rhodeTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "SC":
                    var scTemplateMapper = new SouthCarolinaTemplates();
                    returnIndentification = scTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "SOUTH CAROLINA":
                    var southcTemplateMapper = new SouthCarolinaTemplates();
                    returnIndentification = southcTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "SD":
                    var sdTemplateMapper = new SouthDakotaTemplates();
                    returnIndentification = sdTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "SOUTH DAKOTA":
                    var southdTemplateMapper = new SouthDakotaTemplates();
                    returnIndentification = southdTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "TN":
                    var tnTemplateMapper = new TennesseeTemplates();
                    returnIndentification = tnTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "TENNESEE":
                    var tennTemplateMapper = new TennesseeTemplates();
                    returnIndentification = tennTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "TX":
                    var txTemplateMapper = new TexasTemplates();
                    returnIndentification = txTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "TEXAS":
                    var texTemplateMapper = new TexasTemplates();
                    returnIndentification = texTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "UT":
                    var utTemplateMapper = new UtahTemplates();
                    returnIndentification = utTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "UTAH":
                    var utahTemplateMapper = new UtahTemplates();
                    returnIndentification = utahTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "VT":
                    var vtTemplateMapper = new VermontTemplates();
                    returnIndentification = vtTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "VERMONT":
                    var vermontTemplateMapper = new VermontTemplates();
                    returnIndentification = vermontTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "VA":
                    var vaTemplateMapper = new VirginiaTemplates();
                    returnIndentification = vaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "VIRGINIA":
                    var virginiaTemplateMapper = new VirginiaTemplates();
                    returnIndentification = virginiaTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WA":
                    var waTemplateMapper = new WashingtonTemplates();
                    returnIndentification = waTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WASHINGTON":
                    var washTemplateMapper = new WashingtonTemplates();
                    returnIndentification = washTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WV":
                    var wvTemplateMapper = new WestVirginiaTemplates();
                    returnIndentification = wvTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WEST VIRGINIA":
                    var westvTemplateMapper = new WestVirginiaTemplates();
                    returnIndentification = westvTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WI":
                    var wiTemplateMapper = new WisconsinTemplates();
                    returnIndentification = wiTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WISCONSIN":
                    var wiscTemplateMapper = new WisconsinTemplates();
                    returnIndentification = wiscTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WY":
                    var wyTemplateMapper = new WyomingTemplates();
                    returnIndentification = wyTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
                case "WYOMING":
                    var wyomTemplateMapper = new WyomingTemplates();
                    returnIndentification = wyomTemplateMapper.MapDataToTemplate(identificationData.DataList);
                    break;
            }

            return returnIndentification;
        }
    }
}
