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
    public class TestController : ApiController
    {

        private TestModel model = new TestModel();

        [HttpGet]
        [Route("api/ordery-service/test-info")]
        
        public HttpResponseMessage info()
        {
            try
            {
                
                List<DTOTest> listDTO = model.test();
                string response = JsonConvert.SerializeObject(listDTO); ;
                /*for (int x = 0; x < listDTO.Count; x++)
                {
                    response += "Username: " + listDTO[x].username;
                    response += "Password: " + listDTO[x].password;
                    response += "<br>";
                }*/

                return Request.CreateResponse(HttpStatusCode.OK, "Result: " + response);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPost]
        [Route("api/ordery-service/test-insert")]
        public HttpResponseMessage insert([FromBody] DTOParams dtoParams)
        {
            try
            {
                model.insert(dtoParams);
                return Request.CreateResponse(HttpStatusCode.OK, "insert ok! ");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/ordery-service/test-update")]
        public HttpResponseMessage update([FromBody] DTOParams dtoParams)
        {
            try
            {
                model.update(dtoParams);
                return Request.CreateResponse(HttpStatusCode.OK, "update ok! ");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
