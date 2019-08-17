using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderyAPI.Controllers
{
    public class RegistrationController : ApiController
    {
        [HttpGet]
        [Route("api/ordery-service/registration-info")]
        public HttpResponseMessage info()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "registration ok!");
        }
    }
}
