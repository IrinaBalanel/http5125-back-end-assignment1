using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET: localhost:xx/api/AddTen/{id}
        /// <summary>
        /// Recieves an input number and returns that number with added value of 10.
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>
        /// Returns the number with added value of 10.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/AddTen/21 => 31
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/AddTen/0 => 10
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/AddTen/-9 => 1
        /// </example>

        public int Get(int id)
        {
            int result = id + 10;
            return result;
        }
    }

}
