using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Utils
{
    public abstract class DBCRUD 
    {
        protected void createMethod(string SQL, ArrayList al)
        {

        }

        protected void updateMethod(string SQL, ArrayList al)
        {

        }

        protected void deleteMethod(string SQL, ArrayList al)
        {

        }

        protected List<ArrayList> readMethod(string SQL, ArrayList al)
        {
            DBConf.openConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = DBConf.getConnection();
            cmd.CommandText = SQL;
            
            StatementBinding stb = new StatementBinding(cmd);
            stb.bindStatement(al);
            cmd = stb.getPreparedCommand();

            ResultBinding rb = new ResultBinding(cmd);
            List<ArrayList> result = rb.bindResult();
            cmd.Dispose();
            DBConf.closeConnection();

            return result;
        }
    }
}