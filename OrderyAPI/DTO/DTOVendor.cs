using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.DTO
{
    public class DTOVendorProfile
    {
        int vendor_login { get; set; }
        string account { get; set; }
        string name { get; set; }
        int region { get; set; }
        string province { get; set; }
        int municipality { get; set; }
        int bgy { get; set; }
        string address { get; set; }
        string zip { get; set; }
        string email { get; set; }
        string contact { get; set; }
        string gender { get; set; }
    }

    public class DTOVendorLogin
    {
        int id { get; set; }
        string username { get; set; }
        string password { get; set; }
        string tbl { get; set; }
        string store { get; set; }
        string food_category { get; set; }
        string food_menu { get; set; }
    }


}