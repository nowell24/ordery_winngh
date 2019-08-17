using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OrderyAPI.Abstract
{
    public abstract class DBConnect
    {
        protected SqlConnection myConnection;
        public void CreateConnection()
        {
            myConnection = new SqlConnection();
            myConnection.ConnectionString = "Persist Security Info=False;database=myDB;server=myHost;Connect Timeout=30;user id=myUser; pwd=myPass";
            myConnection.Open();
        }
    }
}