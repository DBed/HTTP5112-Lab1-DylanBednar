using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Lab1_DylanBednar.Controllers
{
    public class HostingCostController : ApiController
    {
        //GET api/hostingcost
        /// <summary>
        /// Receives the value of the integer, divides by 14 then adds 1.  This total is multiplied by the fortnight rate, then tax is applied before displaying the total. 
        /// </summary>
        /// <param name="id"> 28 </param>
        /// <returns> 3 fortnights at $5.50/FN = $16.5 HST 13% = $2.14 CAD Total = $18.64 CAD </returns>
        public string GET(int id) 
        {   
            //nights divided by 14 to find # of fortnights
            var fortnights = (id / 14 + 1);
            var preTax = fortnights * 5.50;
            var tax = preTax * 0.13;
            var total = preTax + tax;
            var line1 = fortnights + " fortnights at $5.50/FN = " + "$" + Math.Round(preTax, 2) + "    ";
            var line2 = "HST 13% = $" + Math.Round(tax, 2) + " CAD   ";
            var line3 = "Total = $" + Math.Round(total, 2) + " CAD";  //found Math.Round tip here: https://stackoverflow.com/questions/257005/how-do-you-round-a-number-to-two-decimal-places-in-c

            return line1 + line2 + line3;  //Didn't know how to return multiple lines 
        
        }
    }
}
