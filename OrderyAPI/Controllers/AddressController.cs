using Newtonsoft.Json;
using OrderyAPI.DTO;
using OrderyAPI.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderyAPI.Controllers
{
    public class AddressController : ApiController
    {
        private AddressModel model = new AddressModel();

        [HttpGet]
        [Route("api/ordery-service/regions")]
        public HttpResponseMessage regions()
        {
            try
            {
                List<DTORegion> listDTO = model.getRegions();
                string response = JsonConvert.SerializeObject(listDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "{\"regions\": " + response + "}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpGet]
        [Route("api/ordery-service/provinces")]
        public HttpResponseMessage provinces([FromBody] DTOParams dtoParams)
        {
            try
            {
                List<DTOProvince> listDTO = model.getProvinces(dtoParams);
                string response = JsonConvert.SerializeObject(listDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "{\"provinces\": " + response + "}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/ordery-service/municipalities")]
        public HttpResponseMessage municipalities([FromBody] DTOParams dtoParams)
        {
            try
            {
                List<DTOMunicipality> listDTO = model.getMunicipalities(dtoParams);
                string response = JsonConvert.SerializeObject(listDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "{\"municipalities\": " + response + "}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/ordery-service/barangays")]
        public HttpResponseMessage barangays([FromBody] DTOParams dtoParams)
        {
            try
            {
                List<DTOBarangay> listDTO = model.getBarangays(dtoParams);
                string response = JsonConvert.SerializeObject(listDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "{\"barangays\": " + response + "}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
