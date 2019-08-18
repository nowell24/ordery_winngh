using OrderyAPI.DTO;
using System.Collections;
using System.Collections.Generic;

namespace OrderyAPI.Utils
{
    public abstract class DAOFactory : DBCRUD
    {
        public abstract void upsert(string SQL, DTOParams dto);
        public abstract void delete(string SQL, DTOParams dto);
        public abstract List<ArrayList> read(string SQL, DTOParams dto);
       
    }
}