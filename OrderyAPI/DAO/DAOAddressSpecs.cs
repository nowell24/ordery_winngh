using System;
using System.Collections;
using System.Collections.Generic;
using OrderyAPI.DTO;
using OrderyAPI.Utils;

namespace OrderyAPI.DAO
{
    public class DAOAddressSpecs : DAOFactory
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