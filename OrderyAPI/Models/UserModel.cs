using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Models
{
    public class UserModel
    {
        public void createLogin(DTOParams dtoParams)
        {
            DTOParams dtoLogin = new DTOParams();
            dtoLogin.params0 = dtoParams.params0; 
            dtoLogin.params1 = SaltString.RandomString(10, true); 
            dtoLogin.params2 = Cipher.Encrypt(dtoParams.params1, dtoLogin.params1);
            TableName tn = new TableName();
            tn.city = "1";//dtoParams.params4;
            tn.setNewTableName();
            Console.Write(tn.table);
            //dtoLogin.params2 = 
        }
    }
}