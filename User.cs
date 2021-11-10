using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoreConsoleApp
{
    //public class User
    //{
    //    public int Id { get; set; }
    //    public string DisplayName { get; set; }
    //    public string Gender { get; set; }
    //    public string Login { get; set; }

    //    public var jsonText = @"
    //    {
    //    ""Items"": [{
	   //     ""Id"": ""1"",
	   //     ""EmployeeNo"": ""1001"",
	   //     ""FirstName"": ""Rajat"",
	   //     ""LastName"": ""Kumar"",
	   //     ""Gender"": {
		  //      ""Id"": ""1"",
		  //      ""ShortName"": ""M"",
		  //      ""FullName"": ""Male""
	   //     }
    //      }]
    //    }
    //    ";

    //    //var jsonText = @"
    //    //                    {
    //    //                        ""conum"" : 1001,
    //    //                        ""name"" : ""CLN Industries Corporation"",
    //    //                        ""agencyName"" : ""Murphy, Holmes & Associates, LLC"",
    //    //                        ""sAA"" : [{
    //    //                                ""code"" : 247,
    //    //                                ""description"" : ""Mechanic\u0027s lien - Bond to Discharge - Fixed penalty - where principal has posted Performance and Pa""
    //    //                            }, {
    //    //                                ""code"" : 277,
    //    //                                ""description"" : ""Mechanic\u0027s lien - Bond to Discharge - Open Penalty - where principal has posted Performance and Paym""
    //    //                            }, {
    //    //                                ""code"" : 505,
    //    //                                ""description"" : ""Indemnity Bonds - Contractor\u0027s Indemnity Against Damages where there is a performance bond and addit""
    //    //                            }
    //    //                        ]
    //    //                    }
    //    //                ";


    //    public void UserProfile()
    //    {
    //        CreateMap<JObject, List<User>>().ConvertUsing<JObjectToUserListConverter>();
    //        var employeeMap = new MapperConfiguration(
    //          cfg => cfg.CreateMap<JToken, User>()
    //         .ForMember(x => x.Id, y => y.MapFrom(j => j.SelectToken(".Id")))
    //         .ForMember(x => x.DisplayName, y => y.MapFrom(j => j.SelectToken(".LastName").ToString() + ", " + j.SelectToken(".FirstName").ToString()))
    //         .ForMember(x => x.Gender, y => y.MapFrom(j => j.SelectToken(".Gender.FullName")))
    //         .ForMember(x => x.Login, y => y.MapFrom(j => j.SelectToken(".Login")))
    //         );
    //    }

    //}
}

