using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.DTO
{
    public class DTOUserProfile
    {
        int user_login { get; set; }
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
        int sec_q1 { get; set; }
        string sec_q1_ans { get; set; }
        int sec_q2 { get; set; }
        string sec_q2_ans { get; set; }
    }

    public class DTOUserLogin
    {
        int id { get; set; }
        string username { get; set; }
        string password { get; set; }
        string tbl { get; set; }
    }
}