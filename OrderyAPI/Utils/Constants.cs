using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Utils
{
    public abstract class Constants
    {
        public static string TESTQUERY = "SELECT username, password FROM tbl_test";
        public static string TESTINSERT = "INSERT INTO tbl_test (username, password) VALUES (@params0, @params1)";
        public static string TESTUPDATE = "UPDATE tbl_test SET username=@params0, password=@params1 WHERE id=@params2";
    }
}