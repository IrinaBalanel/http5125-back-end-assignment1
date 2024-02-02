using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //Get: localhost:xx/api/Square/{id}
        /// <summary>
        /// Recieves an input number and returns the square of that number (multiplied by the same number).
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>
        /// Returns the square of the number.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/AddTen/2 => 4
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/AddTen/-2 => 4
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/AddTen/10 => 100
        /// </example>

        public int Get(int id)
        {
            int result = id * id;
            return result;
        }
    }
}
