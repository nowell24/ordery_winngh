using OrderyAPI.Utils;
using System.Collections.Generic;
using System.Collections;
using OrderyAPI.DTO;

namespace OrderyAPI.DAO
{
    public class DAOTest : DAOFactory
    {
        public override void upsert(string SQL, DTOParams dto)
        {
            upsertMethod(SQL, dto);
        }

        public override void delete(string SQL, DTOParams dto)
        {
            
        }

        public override List<ArrayList> read(string SQL, DTOParams dto)
        {
            return readMethod(SQL, dto); 
        }

        
    }
}