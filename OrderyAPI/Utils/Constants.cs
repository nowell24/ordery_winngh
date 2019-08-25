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
        public static string GETREGIONS = "SELECT SQL_NO_CACHE id, name FROM region ORDER BY id";
        public static string GETPROVINCES = "SELECT SQL_NO_CACHE id, name FROM province WHERE region=@params0 ORDER BY id";
        public static string GETMUNICIPALITIES = "SELECT SQL_NO_CACHE id, name FROM municipality WHERE province=@params0 ORDER BY id";
        public static string GETBARANGAYS = "SELECT SQL_NO_CACHE id, name FROM barangay WHERE municipality=@params0 ORDER BY id";
        //user specifics
        public static string CREATEUSER = "INSERT INTO @table0 (user_login, account, name, region, province, municipality, address, zip, bgy, email, contact, gender, sec_q1, sec_q1_ans, sec_q2, sec_q2_ans, image_uri) "
                                        + "VALUES (@params0, @params1, @params2, @params3, @params4, @params5, @params6, @params7, @params8, @params9, @params10, @params11, @params12, @params13, @params14, @params15) ";
        public static string CREATEUSERLOGIN = "INSERT INTO user_login (username, password, tbl) VALUES (params0, params1, params2)";
        public static string GETUSER = "SELECT SQL_NO_CACHE "
                                        + "name, "
                                        + "email, "
                                        + "contact, "
                                        + "gender, "
                                        + "bday, "
                                        + "address, "
                                        + "zip, "
                                        + "image_uri "
                                        + "FROM "
                                        + "@table0 "
                                        + "WHERE "
                                        + "user_login = @params1 ";
        public static string GETVENDORINFO = "SELECT SQL_NO_CACHE "
                                        + "name, "
                                        + "email, "
                                        + "contact, "
                                        + "gender, "
                                        + "bday, "
                                        + "address, "
                                        + "zip, "
                                        + "image_uri "
                                        + "FROM "
                                        + "@params0, "
                                        + "WHERE "
                                        + "vendor_login = @params1 ";
        public static string GETSTOREINFO = "SELECT SQL_NO_CACHE "
                                        + "name, "
                                        + "contact, "
                                        + "email, "
                                        + "fb, "
                                        + "ig, "
                                        + "tw, "
                                        + "is_always_open, "
                                        + "store_opens, "
                                        + "store_closes, "
                                        + "longhitude, "
                                        + "latitude, "
                                        + "store_closes, "
                                        + "image_uri "
                                        + "FROM "
                                        + "@params0, "
                                        + "WHERE "
                                        + "vendor_login = @params1 ";
        public static string GETFOODCATEGORIES = "SELECT SQL_NO_CACHE "
                                        + "name, "
                                        + "description "
                                        + "FROM "
                                        + "@params0, "
                                        + "WHERE "
                                        + "store = @params1 ";
        public static string GETFOODMENU = "SELECT SQL_NO_CACHE "
                                        + "name, "
                                        + "description, "
                                        + "price, "
                                        + "image_uri "
                                        + "FROM "
                                        + "@params0, "
                                        + "WHERE "
                                        + "store = @params1 "
                                        + "AND "
                                        + "food_category = @params2 ";
    }
}