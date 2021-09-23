using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Lab1_DylanBednar.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET numbermachine
        // return (id+5) * 3 / 2 + 8
        /// <summary>
        /// Receives an integer then performs a series of mathematic operations. 
        /// </summary>
        /// <param name="id"> 5 </param>
        /// <returns> 23 </returns>
        public int GET(int id) 
        {
            return (id + 5) * 3 / 2 + 8;
        }

    }
}
