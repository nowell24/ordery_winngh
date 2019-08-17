using OrderyAPI.DAO;
using OrderyAPI.DTO;
using OrderyAPI.Models;
using OrderyAPI.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderyAPI.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/ordery-service/test-info")]
        public HttpResponseMessage info()
        {
            try
            {
                TestModel model = new TestModel();
                List<DTOTest> listDTO = model.test();
                string response = "";
                for (int x = 0; x < listDTO.Count; x++)
                {
                    response += "Username: "+listDTO[x].Username;
                    response += "Password: " + listDTO[x].Password;
                    response += "<br>";
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Result:<br> "+ response);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
            
        }
    }
}
