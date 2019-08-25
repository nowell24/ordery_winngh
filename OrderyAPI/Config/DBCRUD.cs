using OrderyAPI.DTO;
using System.Collections;
using System.Collections.Generic;

namespace OrderyAPI.Utils
{
    public abstract class DBCRUD : DBHelper
    {
        protected void upsertMethod(string SQL, DTOParams dto)
        {
            init(SQL, dto);
            cmd.ExecuteNonQuery();
            close();
        }

        protected void deleteMethod(string SQL, DTOParams dto)
        {

        }

        protected List<ArrayList> readMethod(string SQL, DTOParams dto)
        {
            init(SQL, dto);
            List<ArrayList> result = new ResultBinding(cmd).bindResult();
            close();

            return result;
        }
    }
}