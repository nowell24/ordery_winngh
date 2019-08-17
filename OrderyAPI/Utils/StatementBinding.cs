using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Utils
{
    public class StatementBinding
    {
        private MySqlCommand cmd;
        public StatementBinding(MySqlCommand cmd)
        {
            cmd.Prepare();
            this.cmd = cmd;
        }

        public MySqlCommand getPreparedCommand()
        {
            return cmd;
        }

        public void bindStatement(ArrayList al)
        {
            switch (al.Count)
            {
                case 1:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    break;
                case 2:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    break;
                case 3:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    break;
                case 4:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    break;
                case 5:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    break;
                case 6:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    break;
                case 7:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    break;
                case 8:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    cmd.Parameters.AddWithValue("@params7", al[7]);
                    break;
                case 9:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    cmd.Parameters.AddWithValue("@params7", al[7]);
                    cmd.Parameters.AddWithValue("@params8", al[8]);
                    break;
                case 10:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    cmd.Parameters.AddWithValue("@params7", al[7]);
                    cmd.Parameters.AddWithValue("@params8", al[8]);
                    cmd.Parameters.AddWithValue("@params9", al[9]);
                    break;
                case 11:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    cmd.Parameters.AddWithValue("@params7", al[7]);
                    cmd.Parameters.AddWithValue("@params8", al[8]);
                    cmd.Parameters.AddWithValue("@params9", al[9]);
                    cmd.Parameters.AddWithValue("@params10", al[10]);
                    break;
                case 12:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    cmd.Parameters.AddWithValue("@params7", al[7]);
                    cmd.Parameters.AddWithValue("@params8", al[8]);
                    cmd.Parameters.AddWithValue("@params9", al[9]);
                    cmd.Parameters.AddWithValue("@params10", al[10]);
                    cmd.Parameters.AddWithValue("@params11", al[11]);
                    break;
                case 13:
                    cmd.Parameters.AddWithValue("@params0", al[0]);
                    cmd.Parameters.AddWithValue("@params1", al[1]);
                    cmd.Parameters.AddWithValue("@params2", al[2]);
                    cmd.Parameters.AddWithValue("@params3", al[3]);
                    cmd.Parameters.AddWithValue("@params4", al[4]);
                    cmd.Parameters.AddWithValue("@params5", al[5]);
                    cmd.Parameters.AddWithValue("@params6", al[6]);
                    cmd.Parameters.AddWithValue("@params7", al[7]);
                    cmd.Parameters.AddWithValue("@params8", al[8]);
                    cmd.Parameters.AddWithValue("@params9", al[9]);
                    cmd.Parameters.AddWithValue("@params10", al[10]);
                    cmd.Parameters.AddWithValue("@params11", al[11]);
                    cmd.Parameters.AddWithValue("@params12", al[12]);
                    break;
                case 14: break;
                case 15: break;
                case 16: break;
                case 17: break;
                case 18: break;
                case 19: break;
                case 20: break;
                case 21: break;
                case 22: break;
                case 23: break;
                case 24: break;
                case 25: break;
                case 26: break;
                case 27: break;
                case 28: break;
                case 29: break;
                case 30: break;
                case 31: break;
                case 32: break;
                case 33: break;
                case 34: break;
                case 35: break;
                case 36: break;
                case 37: break;
                case 38: break;
                case 39: break;
                default: break;

            }
        }
    }
}