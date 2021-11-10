using System;
using Newtonsoft.Json.Linq;
using AutoMapper;
using System.Collections;
using System.Collections.Generic;


namespace CoreConsoleApp
{
     
    public class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Gender { get; set; }
        public string Login { get; set; }
    }
    public class CorporateRatesProfile2 :Profile
    {
         public CorporateRatesProfile2()
        {
            //CreateMap<JObject, CorporateRatesInfo>()
            //    .ForMember("SaaCodes", cfg => { cfg.MapFrom(jo => jo["sAA"]); })
            //    .ForMember("Conum", cfg => { cfg.MapFrom(jo => jo["conum"]); })
            //    .ForMember("Name", cfg => { cfg.MapFrom(jo => jo["name"]); })
            //    .ForMember("AgencyName", cfg => { cfg.MapFrom(jo => jo["agencyName"]); });

            CreateMap<JObject, User>()
               .ForMember("Id", cfg => { cfg.MapFrom(jo => jo["Items.Id"]); })
               .ForMember("DisplayName", cfg => { cfg.MapFrom(jo => jo["Items.FirstName"]); })
               .ForMember("Gender", cfg => { cfg.MapFrom(jo => jo["Items.Gender.FullName"]); })
               .ForMember("Login", cfg => { cfg.MapFrom(jo => jo["Items.LastName"]); });

            //CreateMap<JObject, List<User>>().ConvertUsing<JObjectToUserListConverter>();
            //var employeeMap = new MapperConfiguration(
            //  cfg => cfg.CreateMap<JToken, User>()
            // .ForMember(x => x.Id, y => y.MapFrom(j => j.SelectToken(".Id")))
            // .ForMember(x => x.DisplayName, y => y.MapFrom(j => j.SelectToken(".LastName").ToString() + ", " + j.SelectToken(".FirstName").ToString()))
            // .ForMember(x => x.Gender, y => y.MapFrom(j => j.SelectToken(".Gender.FullName")))
            // .ForMember(x => x.Login, y => y.MapFrom(j => j.SelectToken(".Login")))
            // );
        }
    }


    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JObject, User>();
                cfg.AddProfile<CorporateRatesProfile2>();
            });

            var mapper = config.CreateMapper();

            var jsonText = @"
             {
             ""Items"": [{
              ""Id"": ""1"",
              ""EmployeeNo"": ""1001"",
              ""FirstName"": ""Rajat"",
              ""LastName"": ""Kumar"",
              ""Gender"": {
               ""Id"": ""1"",
               ""ShortName"": ""M"",
               ""FullName"": ""Male""
              }
               }]
             }
             ";

            //config.AssertConfigurationIsValid();
            var jsonoObj = JObject.Parse(jsonText);
            User dt = mapper.Map<User>(jsonoObj);
        }
    }
}
