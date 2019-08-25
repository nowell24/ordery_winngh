using OrderyAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OrderyAPI.DTO;
using System.Collections;

namespace OrderyAPI.DAO
{
    public class DAOSeqTbl : DAOFactory
    {
        public override void delete(string SQL, DTOParams dto)
        {
            throw new NotImplementedException();
        }

        public override List<ArrayList> read(string SQL, DTOParams dto)
        {
            return readMethod(SQL, dto);
        }

        public override void upsert(string SQL, DTOParams dto)
        {
            throw new NotImplementedException();
        }
    }
}