using OrderyAPI.DAO;
using OrderyAPI.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderyAPI.Utils
{
    public class TableName
    {
        public string table { get; set; }
        public string city { get; set; }

        public void setNewTableName()
        {
            DAOFactory factory = new DAOSeqTbl();
            DTOParams dto = new DTOParams();
            dto.params0 = city;
            List<ArrayList> result = factory.read(Constants.GETSEQUENCE, dto);
            table = "user_"+result[0][3].ToString() + "_"+DateTime.Now.Year;
        }
    }
}