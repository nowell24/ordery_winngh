using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.DAO
{
    public class DAOUser : DAOFactory
    {
        public override void delete(string SQL, DTOParams dto)
        {
            throw new NotImplementedException();
        }

        public override List<ArrayList> read(string SQL, DTOParams dto)
        {
            throw new NotImplementedException();
        }

        public override void upsert(string SQL, DTOParams dto)
        {
            upsertMethod(SQL, dto);
        }
    }
}