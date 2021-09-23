using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Lab1_DylanBednar.Controllers
{
    public class AddTenController : ApiController
    {   
        //GET api/addbloop
        //return sum of id + 10
        /// <summary>
        /// Adds 10 to the integer received as input. 
        /// </summary>
        /// <param name="id"> 4 </param>
        /// <returns> 14 </returns>
        public int Get(int id) 
        {
            return id+10;
        }
    }
}
