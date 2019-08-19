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
        public static string GETREGIONS = "SELECT id, name FROM region ORDER BY id";
        public static string GETPROVINCES = "SELECT id, name FROM province WHERE region=@params0 ORDER BY id";
        public static string GETMUNICIPALITIES = "SELECT id, name FROM municipality WHERE province=@params0 ORDER BY id";
        public static string GETBARANGAYS = "SELECT id, name FROM barangay WHERE municipality=@params0 ORDER BY id";
    }
}