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
        /*
        Gets all regions

        params:
            None

        return:
            {
                regions: [
                    {
                        id: 1,
                        name: Region I
                    },
                    {
                        id: 2,
                        name: Region II
                    },
                ]
            }
        */
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
        /*
        Gets all provinces by region id

        params:
            {
                params0: (integer) region id,
                count: 1
            }

        return:
            {
                regions: [
                    {
                        id: 1,
                        name: Ilocos Norte
                    },
                    {
                        id: 2,
                        name: Ilocos Sur
                    },
                ]
            }
        */
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
        /*
        Gets all municipalities by province id

        params:
            {
                params0: (integer) province id,
                count: 1
            }

        return:
            {
                regions: [
                    {
                        id: 1,
                        name: Paco
                    },
                    {
                        id: 2,
                        name: Pandacan
                    },
                ]
            }
        */
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
        /*
        Gets all barangays by municipality id

        params:
            {
                params0: (integer) municipality id,
                count: 1
            }

        return:
            {
                regions: [
                    {
                        id: 1,
                        name: Poblacion I
                    },
                    {
                        id: 2,
                        name: Poblacion II
                    },
                ]
            }
        */
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
