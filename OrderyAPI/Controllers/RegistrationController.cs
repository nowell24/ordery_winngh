using OrderyAPI.DTO;
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
        [Route("api/ordery-service/security-questions")]
        public HttpResponseMessage securityQuestions()
        /*
        Gets security questions

        params:
            None

        return:
            {
                security_questions: [
                    {
                        id: 1,
                        security_question: What is your favorite sport ?
                    },
                    {
                        id: 2,
                        security_question: Who is your childhood superhero ?
                    },
                ]
            }
        */
        {
            try
            {
                string response = "";
                return Request.CreateResponse(HttpStatusCode.OK, "{\"security_questions\": " + response + "}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPut]
        [Route("api/ordery-service/customer/registration")]
        public HttpResponseMessage customerRegistration([FromBody] DTOParams dtoParams)
        /*
        Creates customer account

        params:
            {
                params0: (string) email,
                params1: (string) contact,
                params2: (string) name,
                params3: (string) gender,
                params4: (date) birthday,
                params5: (integer) region id,
                params6: (integer) province id,
                params7: (integer) municipality id,
                params8: (integer) barangay id,
                params9: (string) address,
                params10: (string) zip code,
                params11: (integer) security question 1 id,
                params12: (string) security question 1 answer,
                params13: (integer) security question 2 id,
                params14: (string) security question 2 answer,
                params15: (string) password,
                params16: (string) image,
                count: 17
            }

        return:
            {
                message: Successful!
            }
        */
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "{\"message\": \"Successful!\"}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/ordery-service/vendor/registration")]
        public HttpResponseMessage vendorRegistration([FromBody] DTOParams dtoParams)
        /*
        Creates vendor account

        params:
            {
                params0: (string) email,
                params1: (string) contact,
                params2: (string) name,
                params3: (string) gender,
                params4: (date) birthday,
                params5: (integer) region id,
                params6: (integer) province id,
                params7: (integer) municipality id,
                params8: (integer) barangay id,
                params9: (string) address,
                params10: (string) zip code,
                params11: (integer) security question 1 id,
                params12: (string) security question 1 answer,
                params13: (integer) security question 2 id,
                params14: (string) security question 2 answer,
                params15: (string) password,
                params16: (string) image,
                params17: (string) store email,
                params18: (string) store contact,
                params19: (string) store name,
                params20: (integer) store province id,
                params21: (string) store address,
                params22: (string) store zipcode,
                params23: (string) store facebook,
                params24: (string) store instagram,
                params25: (string) store twitter,
                params26: (boolean) store is always open?,
                params27: (time) store opens,
                params28: (time) store closes,
                params29: (decimal) store longitude,
                params30: (decimal) store latitude,
                params31: (string) store image
                count: 32
            }

        return:
            {
                message: Successful!
            }
        */
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "{\"message\": \"Successful!\"}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPut]
        [Route("api/ordery-service/rider/registration")]
        public HttpResponseMessage riderRegistration([FromBody] DTOParams dtoParams)
        /*
        Creates rider account

        params:
            {
                params0: (string) email,
                params1: (string) contact,
                params2: (string) name,
                params3: (string) gender,
                params4: (date) birthday,
                params5: (integer) region id,
                params6: (integer) province id,
                params7: (integer) municipality id,
                params8: (integer) barangay id,
                params9: (string) address,
                params10: (string) zip code,
                params11: (integer) security question 1 id,
                params12: (string) security question 1 answer,
                params13: (integer) security question 2 id,
                params14: (string) security question 2 answer,
                params15: (string) password,
                params16: (string) image,
                params17: (string) motor model,
                params18: (string) motor year,
                params19: (string) moror color,
                params20: (string) motor plate number,
                params21: (string) motor image
                count: 22
            }

        return:
            {
                message: Successful!
            }
        */
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, "{\"message\": \"Successful!\"}");
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
