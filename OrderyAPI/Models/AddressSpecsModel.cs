using OrderyAPI.DAO;
using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OrderyAPI.Models
{
    public class AddressSpecsModel
    {
        private DAOFactory dao = new DAOAddressSpecs();

        public List<DTOAddressSpecs> getAll()
        {
            List<DTOAddressSpecs> listDTO = new List<DTOAddressSpecs>();
            List<ArrayList> result = dao.read(Constants.GETADDRSPECS, new DTOParams());
            for (int x = 0; x < result.Count; x++)
            {
                DTOAddressSpecs dto = new DTOAddressSpecs();
                dto.regionId = result[x][0].ToString();
                dto.regionName = result[x][1].ToString();
                dto.municipalityId = result[x][2].ToString();
                dto.municipalityName = result[x][3].ToString();
                dto.bgyId = result[x][4].ToString();
                dto.bgyName = result[x][5].ToString();
                
                listDTO.Add(dto);
            }

            return listDTO;
        }
    }
}