using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Utils
{
    public class ResultBinding
    {
        private MySqlCommand cmd;
        public ResultBinding(MySqlCommand cmd)
        {
            this.cmd = cmd;
        }

        public List<ArrayList> bindResult()
        {
            MySqlDataReader reader = cmd.ExecuteReader();
            List<ArrayList> bindedResult = new List<ArrayList>();
            while (reader.Read())
            {
                ArrayList result = new ArrayList();
                switch (reader.FieldCount)
                {
                    case 1:
                        result.Add(reader[0]);
                        break;
                    case 2:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        break;
                    case 3:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        break;
                    case 4:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        break;
                    case 5:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        break;
                    case 6:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        break;
                    case 7:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        break;
                    case 8:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        result.Add(reader[7]);
                        break;
                    case 9:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        result.Add(reader[7]);
                        result.Add(reader[8]);
                        break;
                    case 10:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        result.Add(reader[7]);
                        result.Add(reader[8]);
                        result.Add(reader[9]);
                        break;
                    case 11:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        result.Add(reader[7]);
                        result.Add(reader[8]);
                        result.Add(reader[9]);
                        result.Add(reader[10]);
                        break;
                    case 12:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        result.Add(reader[7]);
                        result.Add(reader[8]);
                        result.Add(reader[9]);
                        result.Add(reader[10]);
                        result.Add(reader[11]);
                        break;
                    case 13:
                        result.Add(reader[0]);
                        result.Add(reader[1]);
                        result.Add(reader[2]);
                        result.Add(reader[3]);
                        result.Add(reader[4]);
                        result.Add(reader[5]);
                        result.Add(reader[6]);
                        result.Add(reader[7]);
                        result.Add(reader[8]);
                        result.Add(reader[9]);
                        result.Add(reader[10]);
                        result.Add(reader[11]);
                        result.Add(reader[12]);
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

                bindedResult.Add(result);
            }
            reader.Close();

            return bindedResult;
        }
    }
}