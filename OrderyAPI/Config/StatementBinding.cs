using MySql.Data.MySqlClient;
using OrderyAPI.DTO;

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

        public void bindStatement(DTOParams dto)
        {
            switch (dto.count)
            {
                case 1:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    break;
                case 2:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    break;
                case 3:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    break;
                case 4:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    break;
                case 5:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    break;
                case 6:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    break;
                case 7:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    break;
                case 8:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    cmd.Parameters.AddWithValue("@params7", dto.params7);
                    break;
                case 9:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    cmd.Parameters.AddWithValue("@params7", dto.params7);
                    cmd.Parameters.AddWithValue("@params8", dto.params8);
                    break;
                case 10:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    cmd.Parameters.AddWithValue("@params7", dto.params7);
                    cmd.Parameters.AddWithValue("@params8", dto.params8);
                    cmd.Parameters.AddWithValue("@params9", dto.params9);
                    break;
                case 11:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    cmd.Parameters.AddWithValue("@params7", dto.params7);
                    cmd.Parameters.AddWithValue("@params8", dto.params8);
                    cmd.Parameters.AddWithValue("@params9", dto.params9);
                    cmd.Parameters.AddWithValue("@params10", dto.params10);
                    break;
                case 12:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    cmd.Parameters.AddWithValue("@params7", dto.params7);
                    cmd.Parameters.AddWithValue("@params8", dto.params8);
                    cmd.Parameters.AddWithValue("@params9", dto.params9);
                    cmd.Parameters.AddWithValue("@params10", dto.params10);
                    cmd.Parameters.AddWithValue("@params11", dto.params11);
                    break;
                case 13:
                    cmd.Parameters.AddWithValue("@params0", dto.params0);
                    cmd.Parameters.AddWithValue("@params1", dto.params1);
                    cmd.Parameters.AddWithValue("@params2", dto.params2);
                    cmd.Parameters.AddWithValue("@params3", dto.params3);
                    cmd.Parameters.AddWithValue("@params4", dto.params4);
                    cmd.Parameters.AddWithValue("@params5", dto.params5);
                    cmd.Parameters.AddWithValue("@params6", dto.params6);
                    cmd.Parameters.AddWithValue("@params7", dto.params7);
                    cmd.Parameters.AddWithValue("@params8", dto.params8);
                    cmd.Parameters.AddWithValue("@params9", dto.params9);
                    cmd.Parameters.AddWithValue("@params10", dto.params10);
                    cmd.Parameters.AddWithValue("@params11", dto.params11);
                    cmd.Parameters.AddWithValue("@params12", dto.params12);
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