using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Lab1_DylanBednar.Controllers
{
    public class GreetingController : ApiController
    {
        //POST api/greeting
        public string Post([FromBody] string value)
        {
            return "Hello World!";
        }
        //GET api/greeting
        /// <summary>
        /// Receives and integer and applies it to a greeting. 
        /// </summary>
        /// <param name="id"> 4 </param>
        /// <returns> Greetings to 4 people! </returns>
        public string GET(string id)
        {
            return "Greetings to " + id + " people!";
        }
    }
}
