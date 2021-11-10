using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using AutoMapper;
using System.Collections;


namespace CoreConsoleApp
{
    public class CorporateRatesInfo
    {
        public string Conum { get; set; }
        public string Name { get; set; }
        public string AgencyName { get; set; }
        public List<SaaCode> SaaCodes { get; set; }
        
    }

    public class SaaCode
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class CorporateRatesProfile : Profile
    {
        public CorporateRatesProfile()
        {
            CreateMap<JObject, SaaCode>()
                .ForMember("Code", cfg => { cfg.MapFrom(jo => jo["code"]); })
                .ForMember("Description", cfg => { cfg.MapFrom(jo => jo["description"]); });

            CreateMap<JObject, CorporateRatesInfo>()
                .ForMember("SaaCodes", cfg => { cfg.MapFrom(jo => jo["sAA"]); })
                .ForMember("Conum", cfg => { cfg.MapFrom(jo => jo["conum"]); })
                .ForMember("Name", cfg => { cfg.MapFrom(jo => jo["name"]); })
                .ForMember("AgencyName", cfg => { cfg.MapFrom(jo => jo["agencyName"]); });


        }
    }

    class Program1
    {
        static void Main(string[] args)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JObject, CorporateRatesInfo>();
                cfg.AddProfile<CorporateRatesProfile>();
            });

            //config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();

            var jsonText = @"
                            {
                                ""conum"" : 1001,
                                ""name"" : ""CLN Industries Corporation"",
                                ""agencyName"" : ""Murphy, Holmes & Associates, LLC"",
                                ""sAA"" : [{
                                        ""code"" : 247,
                                        ""description"" : ""Mechanic\u0027s lien - Bond to Discharge - Fixed penalty - where principal has posted Performance and Pa""
                                    }, {
                                        ""code"" : 277,
                                        ""description"" : ""Mechanic\u0027s lien - Bond to Discharge - Open Penalty - where principal has posted Performance and Paym""
                                    }, {
                                        ""code"" : 505,
                                        ""description"" : ""Indemnity Bonds - Contractor\u0027s Indemnity Against Damages where there is a performance bond and addit""
                                    }
                                ]
                            }
                        ";

            var jsonoObj = JObject.Parse(jsonText);

            CorporateRatesInfo dto = mapper.Map<CorporateRatesInfo>(jsonoObj);
            
            Console.WriteLine("Conum: " + dto.Conum);
            Console.WriteLine("Name: " + dto.Name);
            Console.WriteLine("AgencyName: " + dto.AgencyName);

        }
    }
}
