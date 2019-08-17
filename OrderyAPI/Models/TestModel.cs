using OrderyAPI.DAO;
using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Models
{
    public class TestModel
    {
        private DAOFactory dao = new DAOTest();

        public List<DTOTest> test()
        {
            List <DTOTest> listDTO = new List<DTOTest>();
            List<ArrayList> result = dao.read(Constants.TESTQUERY, new ArrayList());
            for (int x = 0; x < result.Count; x++)
            {
                DTOTest dto = new DTOTest();
                dto.Username = result[x][0].ToString();
                dto.Password = result[x][1].ToString();

                listDTO.Add(dto);
            }

            return listDTO;
        }
    }
}