using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Lab1_DylanBednar.Controllers
{
    public class SquareController : ApiController
    {
        //GET api/square
        //return product of id*id   
        /// <summary>
        /// Receives an integer and multiplies it by itself.
        /// </summary>
        /// <param name="id"> 7 </param>
        /// <returns> 49 </returns>
        public int Get(int id) 
        {
            return id*id;
        }
    }
}
