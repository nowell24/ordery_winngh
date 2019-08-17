using OrderyAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using OrderyAPI.DTO;

namespace OrderyAPI.DAO
{
    public class DAOTest : DAOFactory
    {
        public override void create(string SQL, ArrayList al)
        {
            throw new NotImplementedException();
        }

        public override void delete(string SQL, ArrayList al)
        {
            throw new NotImplementedException();
        }

        public override List<ArrayList> read(string SQL, ArrayList al)
        {
            return readMethod(SQL, al); 
        }

        public override void update(string SQL, ArrayList al)
        {
            throw new NotImplementedException();
        }
    }
}