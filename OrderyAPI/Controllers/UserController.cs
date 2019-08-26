using OrderyAPI.DTO;
using OrderyAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OrderyAPI.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/ordery-service/table-name")]
        public HttpResponseMessage getTN([FromBody] DTOParams dtoParams)
        {
            TableName tn = new TableName();
            tn.city = dtoParams.params0;
            tn.setNewTableName();
            return Request.CreateResponse(HttpStatusCode.OK, "{\"TN\": \""+tn.table+"\"}");
        }
    }
}