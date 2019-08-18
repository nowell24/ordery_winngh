using OrderyAPI.DAO;
using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System.Collections;
using System.Collections.Generic;

namespace OrderyAPI.Models
{
    public class TestModel
    {
        private DAOFactory dao = new DAOTest();

        public List<DTOTest> test()
        {
            
            List <DTOTest> listDTO = new List<DTOTest>();
            List<ArrayList> result = dao.read(Constants.TESTQUERY, new DTOParams());
            for (int x = 0; x < result.Count; x++)
            {
                DTOTest dto = new DTOTest();
                dto.username = result[x][0].ToString();
                dto.password = result[x][1].ToString();

                listDTO.Add(dto);
            }

            return listDTO;
        }

        public void insert(DTOParams dto)
        {
            dao.upsert(Constants.TESTINSERT, dto);
        }

        public void update(DTOParams dto)
        {
            dao.upsert(Constants.TESTUPDATE, dto);
        }
    }
}