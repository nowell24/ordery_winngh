using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.DTO
{
    public class DTOAddressSpecs
    {
        public string regionId { get; set; }
        public string regionName { get; set; }
        public string provinceId { get; set; }
        public string provinceName { get; set; }
        public string municipalityId { get; set; }
        public string municipalityName { get; set; }
        public string bgyId { get; set; }
        public string bgyName { get; set; }
    }
}