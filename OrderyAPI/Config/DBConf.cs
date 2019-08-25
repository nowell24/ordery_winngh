using MySql.Data.MySqlClient;
using System;

namespace OrderyAPI.Utils
{
    public sealed class DBConf
    {
        private static readonly DBConf instance = new DBConf();

        static DBConf()
        {
        }

        private DBConf()
        {
        }

        public static DBConf Instance
        {
            get
            {
                return instance;
            }
        }

        private static MySqlConnection conn;
       
        public static void openConnection()
        {
            try
            {
                conn = new MySqlConnection("Server=166.62.30.116; Database=ordery_winngh; UserID=orderwinuser; Password=!Qazxsw233; Allow User Variables=true");
                conn.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static MySqlConnection getConnection()
        {
            return conn;
        }

        public static void closeConnection()
        {
            conn.Close();
            conn.Dispose();
        }
    }
}