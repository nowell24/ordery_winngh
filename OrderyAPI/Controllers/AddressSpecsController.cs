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
    public class AddressSpecsController : ApiController
    {
        private AddressSpecsModel model = new AddressSpecsModel();

        [HttpGet]
        [Route("api/ordery-service/addressspecs-info")]
        public HttpResponseMessage info()
        {
            try
            {
                List<DTOAddressSpecs> listDTO = model.getAll();
                string response = JsonConvert.SerializeObject(listDTO);
                return Request.CreateResponse(HttpStatusCode.OK, "Result: " + response);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
