using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //Get:  localhost:xx/api/NumberMachine/{id}
        /// <summary>
        /// Recieves an input number and returns that number with four mathematical operations applied.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Returns an input number with added value of 5, substracted value of 10, devided by 2, and multiplied by 3
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/10 => 0
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/-5 => -15
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/NumberMachine/30 => 20
        /// </example>

        public int Get(int id) 
        {
            int result = id + 5 - 10 / 2 * 3;
            return result;
        }
    }
}
