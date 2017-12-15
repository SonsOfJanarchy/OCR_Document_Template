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
            var modelCollection = new List<IdentificationReturnModel>();

            foreach (var items in identificationData.DataList)
            {
                if ((items.Value.Equals("AL", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Alabama", StringComparison.InvariantCultureIgnoreCase)))
                    {

                    var alTemplatemapper = new AlabamaTemplates();
                    var results = alTemplatemapper.MapDataToTemplate(identificationData.DataList);
                    modelCollection.Add(results);

                    }

                if ((items.Value.Equals("AK", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Alaska", StringComparison.InvariantCultureIgnoreCase)))
                    {

                    var akTemplatemapper = new AlaskaTemplates();
                    var results1 = akTemplatemapper.MapDataToTemplate(identificationData.DataList);
                    modelCollection.Add(results1);

                if ((items.Value.Equals("AZ", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Arizona", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var azTemplatemapper = new ArizonaTemplates();
                        var results2 = azTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results2);

                    }

                if ((items.Value.Equals("AR", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Arkansas", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var arTemplatemapper = new ArkansasTemplates();
                        var results3 = arTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results3);

                    }

                if ((items.Value.Equals("CA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("California", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var caTemplatemapper = new CaliforniaTemplates();
                        var results4 = caTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results4);

                    }

                if ((items.Value.Equals("CO", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Colorado", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var coTemplatemapper = new ColoradoTemplates();
                        var results5 = coTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results5);

                    }

                if ((items.Value.Equals("CT", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Connecticut", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var ctTemplatemapper = new ConnecticutTemplates();
                        var results6 = ctTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results6);

                    }

                if ((items.Value.Equals("DE", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Delaware", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var deTemplatemapper = new DelawareTemplates();
                        var results7 = deTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results7);

                    }

                if ((items.Value.Equals("DC", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("District of Columbia", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var dcTemplatemapper = new DistrictOfColumbiaTemplates();
                        var results8 = dcTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results8);

                    }

                if ((items.Value.Equals("FL", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Florida", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var flTemplatemapper = new FloridaTemplates();
                        var results9 = flTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results9);

                    }

                if ((items.Value.Equals("GA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Georgia", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var gaTemplatemapper = new GeorgiaTemplates();
                        var results10 = gaTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results10);

                    }

                if ((items.Value.Equals("HI", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Hawaii", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var hiTemplatemapper = new HawaiiTemplates();
                        var results11 = hiTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results11);

                    }

                if ((items.Value.Equals("ID", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("IDAHO", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var idTemplatemapper = new IdahoTemplates();
                        var results12 = idTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results12);

                    }

                if ((items.Value.Equals("IL", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Illinois", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var ilTemplatemapper = new IllinoisTemplates();
                        var results13 = ilTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results13);

                    }

                if ((items.Value.Equals("IN", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Indiana", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var inTemplatemapper = new IndianaTemplates();
                        var results14 = inTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results14);

                    }

                if ((items.Value.Equals("IA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Iowa", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var iaTemplatemapper = new IowaTemplates();
                        var results15 = iaTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results15);

                    }

                if ((items.Value.Equals("KS", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Kansas", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var ksTemplatemapper = new KansasTemplates();
                        var results16 = ksTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results16);

                    }

                if ((items.Value.Equals("KY", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Kentucky", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var kyTemplatemapper = new KentuckyTemplates();
                        var results17 = kyTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results17);

                    }

                if ((items.Value.Equals("LA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Louisiana", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var laTemplatemapper = new LouisianaTemplates();
                        var results18 = laTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results18);

                    }


                if ((items.Value.Equals("ME", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Maine", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var meTemplatemapper = new MaineTemplates();
                        var results19 = meTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results19);

                    }

                 if ((items.Value.Equals("MD", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Maryland", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var mdTemplatemapper = new MarylandTemplates();
                        var results20 = mdTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results20);

                    }

                 if ((items.Value.Equals("MA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Massachusetts", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var maTemplatemapper = new MassachusettsTemplates();
                        var results21 = maTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results21);

                    }

                 if ((items.Value.Equals("MI", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Michigan", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var miTemplatemapper = new MichiganTemplates();
                        var results22 = miTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results22);

                    }

                 if ((items.Value.Equals("MN", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Minnesota", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var mnTemplatemapper = new MinnesotaTemplates();
                        var results23 = mnTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results23);

                    }

                 if ((items.Value.Equals("MS", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Mississippi", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var msTemplatemapper = new MississippiTemplates();
                        var results24 = msTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results24);

                    }

                 if ((items.Value.Equals("MO", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Missouri", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var moTemplatemapper = new MissouriTemplates();
                        var results25 = moTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results25);

                    }

                 if ((items.Value.Equals("MT", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Montana", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var mtTemplatemapper = new MissouriTemplates();
                        var results26 = mtTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results26);

                    }

                 if ((items.Value.Equals("NE", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Nebraska", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var neTemplatemapper = new NebraskaTemplates();
                        var results27 = neTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results27);

                    }

                 if ((items.Value.Equals("NV", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Nevada", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var nvTemplatemapper = new NevadaTemplates();
                        var results28 = nvTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results28);

                    }

                 if ((items.Value.Equals("NH", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("New Hampshire", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var nhTemplatemapper = new NewHampshireTemplates();
                        var results29 = nhTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results29);

                    }

                 if ((items.Value.Equals("NJ", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("New Jersey", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var njTemplatemapper = new NewJerseyTemplates();
                        var results30 = njTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results30);

                    }

                 if ((items.Value.Equals("NM", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("New Mexico", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var nmTemplatemapper = new NewMexicoTemplates();
                        var results31 = nmTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results31);

                    }

                 if ((items.Value.Equals("NY", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("New York", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var nyTemplatemapper = new NewYorkTemplates();
                        var results32 = nyTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results32);

                    }

                 if ((items.Value.Equals("NC", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("New Carolina", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var ncTemplatemapper = new NorthCarolinaTemplates();
                        var results33 = ncTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results33);

                    }


                 if ((items.Value.Equals("ND", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("North Dakota", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var ndTemplatemapper = new NorthDakotaTemplates();
                        var results34 = ndTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results34);

                    }

                 if ((items.Value.Equals("OH", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Ohio", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var ohTemplatemapper = new OhioTemplates();
                        var results35 = ohTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results35);

                    }

                 if ((items.Value.Equals("OK", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Oklahoma", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var okTemplatemapper = new OklahomaTemplates();
                        var results36 = okTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results36);

                    }

                 if ((items.Value.Equals("OR", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Oregon", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var orTemplatemapper = new OregonTemplates();
                        var results37 = orTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results37);

                    }

                  if ((items.Value.Equals("PA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Pennsylvania", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var paTemplatemapper = new PennsylvaniaTemplates();
                        var results38 = paTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results38);

                    }

                  if ((items.Value.Equals("RI", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Rhode Island", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var riTemplatemapper = new RhodeIslandTemplates();
                        var results39 = riTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results39);

                    }

                  if ((items.Value.Equals("SD", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("South Dakota", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var sdTemplatemapper = new SouthDakotaTemplates();
                        var results40 = sdTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results40);

                    }

                  if ((items.Value.Equals("TN", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Tennesee", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var tnTemplatemapper = new TennesseeTemplates();
                        var results41 = tnTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results41);

                    }

                  if ((items.Value.Equals("TX", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Texas", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var txTemplatemapper = new TexasTemplates();
                        var results42 = txTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results42);

                    }

                  if ((items.Value.Equals("UT", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Utah", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var utTemplatemapper = new UtahTemplates();
                        var results43 = utTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results43);

                    }

                  if ((items.Value.Equals("VT", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Vermont", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var vtTemplatemapper = new VermontTemplates();
                        var results44 = vtTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results44);

                    }

                  if ((items.Value.Equals("VA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Virginia", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var vaTemplatemapper = new VirginiaTemplates();
                        var results45 = vaTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results45);

                    }

                  if ((items.Value.Equals("WA", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Washington", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var waTemplatemapper = new WashingtonTemplates();
                        var results46 = waTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results46);

                    }

                  if ((items.Value.Equals("WV", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("West Virginia", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var wvTemplatemapper = new WestVirginiaTemplates();
                        var results46 = wvTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results46);

                    }

                  if ((items.Value.Equals("WI", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Wisonsin", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var wiTemplatemapper = new WisconsinTemplates();
                        var results47 = wiTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results47);

                    }

                  if ((items.Value.Equals("WY", StringComparison.InvariantCultureIgnoreCase)) || (items.Value.Equals("Wyoming", StringComparison.InvariantCultureIgnoreCase)))
                    {

                        var wyTemplatemapper = new WyomingTemplates();
                        var results48 = wyTemplatemapper.MapDataToTemplate(identificationData.DataList);
                        modelCollection.Add(results48);

                    }

                }
            }

            
            return returnIndentification;
        }
    }
}
