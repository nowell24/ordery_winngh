using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.DTO
{
    public class DTORegion
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class DTOProvince
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class DTOMunicipality
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class DTOBarangay
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}