using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.DTO
{
    public class DTOStore
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
        string fb { get; set; }
        string ig { get; set; }
        string tw { get; set; }
        string is_always_open { get; set; }
        string store_opens { get; set; }
        string store_closes { get; set; }
        double longhitude { get; set; }
        double latitude { get; set; }
        string image_uri { get; set; }
    }

    public class DTOFoodCategory
    {
        int id { get; set; }
        int store { get; set; }
        string name { get; set; }
        string description { get; set; }
    }

    public class DTOFoodMenu
    {
        int id { get; set; }
        int store { get; set; }
        string name { get; set; }
        string description { get; set; }
    }
}