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
        [Route("api/ordery-service/user")]
        public HttpResponseMessage user()
        /*
        Gets user info

        params:
            {
                params0: (integer) user login id,
                count: 1
            }

        return:
            {
                user: {
                    type: vendor,
                    email: rjose@gmail.com,
                    contact: 09267787651,
                    name: Jose Rizal,
                    gender: Male
                    birthday: December 30, 1985,
                    address: address + barangay + municipality + province + region
                    zipcode: 1008
                    security_question_1: What is your favorite sport ?
                    security_question_1_answer: Basketball
                    security_question_2: Who is your childhood superhero ?
                    security_question_2_answer: Tarzan X
                    image: http://gadgetlabsinc.com/ordery/images/upload/USIND123HJDNOSMM27SKDHHD.jpg
                }
            }
        */
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "{\"user\": " + response + "}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
