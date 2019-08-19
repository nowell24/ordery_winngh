using OrderyAPI.DAO;
using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OrderyAPI.Models
{
    public class AddressModel
    {
        private DAOFactory dao = new DAOAddress();

        public List<DTORegion> getRegions()
        {
            List<DTORegion> listDTO = new List<DTORegion>();
            List<ArrayList> result = dao.read(Constants.GETREGIONS, new DTOParams());
            for (int x = 0; x < result.Count; x++)
            {
                DTORegion dto = new DTORegion();
                dto.id = result[x][0].ToString();
                dto.name = result[x][1].ToString();
                listDTO.Add(dto);
            }
            return listDTO;
        }

        public List<DTOProvince> getProvinces(DTOParams dtoParams)
        {
            List<DTOProvince> listDTO = new List<DTOProvince>();
            List<ArrayList> result = dao.read(Constants.GETPROVINCES, dtoParams);
            for (int x = 0; x < result.Count; x++)
            {
                DTOProvince dto = new DTOProvince();
                dto.id = result[x][0].ToString();
                dto.name = result[x][1].ToString();
                listDTO.Add(dto);
            }
            return listDTO;
        }

        public List<DTOMunicipality> getMunicipalities(DTOParams dtoParams)
        {
            List<DTOMunicipality> listDTO = new List<DTOMunicipality>();
            List<ArrayList> result = dao.read(Constants.GETMUNICIPALITIES, dtoParams);
            for (int x = 0; x < result.Count; x++)
            {
                DTOMunicipality dto = new DTOMunicipality();
                dto.id = result[x][0].ToString();
                dto.name = result[x][1].ToString();
                listDTO.Add(dto);
            }
            return listDTO;
        }

        public List<DTOBarangay> getBarangays(DTOParams dtoParams)
        {
            List<DTOBarangay> listDTO = new List<DTOBarangay>();
            List<ArrayList> result = dao.read(Constants.GETBARANGAYS, dtoParams);
            for (int x = 0; x < result.Count; x++)
            {
                DTOBarangay dto = new DTOBarangay();
                dto.id = result[x][0].ToString();
                dto.name = result[x][1].ToString();
                listDTO.Add(dto);
            }
            return listDTO;
        }
    }
}