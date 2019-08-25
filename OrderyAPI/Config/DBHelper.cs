using MySql.Data.MySqlClient;
using OrderyAPI.DTO;

namespace OrderyAPI.Utils
{
    public abstract class DBHelper
    {
        protected MySqlCommand cmd = new MySqlCommand();
        protected void init(string SQL, DTOParams dto)
        {
            DBConf.openConnection();
            cmd.Connection = DBConf.getConnection();
            cmd.CommandText = SQL;
            StatementBinding stb = new StatementBinding(cmd);
            stb.bindStatement(dto);
            cmd = stb.getPreparedCommand();
        }

        protected void close()
        {
            cmd.Dispose();
            DBConf.closeConnection();
        }
    }
}