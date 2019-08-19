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
        public static string GETADDRSPECS = "SELECT SQL_NO_CACHE "
                                            + "region.id, "
                                            + "region.name, "
                                            + "province.id, "
                                            + "province.name, "
                                            + "municipality.id, "
                                            + "municipality.name, "
                                            + "barangay.id, "
                                            + "barangay.name "
                                            + "FROM "
                                            + "region, "
                                            + "province, "
                                            + "municipality, "
                                            + "barangay "
                                            + "WHERE "
                                            + "province.region = region.id "
                                            + "AND "
                                            + "municipality.province = province.id "
                                            + "AND "
                                            + "barangay.municipality = municipality.id ";

    }
}