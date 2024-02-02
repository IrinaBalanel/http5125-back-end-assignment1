using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {   //Post: localhost:xx/api/Greeting/
        /// <summary>
        /// A post request for the webserver
        /// </summary>
        /// <returns>
        /// "Hello World!"
        /// </returns>
        /// <example>
        /// Post: localhost:xx/api/String => "Hello World!"
        /// </example>

        public string Post()
        {
            return "Hello World!";
        }
        
        
        //Get:localhost:xx/api/Greeting/{id}
        /// <summary>
        /// Recieves an input number and returns a message as concatenated string.
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>
        /// This input number concatenated with 2 strings.
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/Greeting/3 => "Greetings to 3 people!"
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Greeting/6 => "Greetings to 6 people!"
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/Greeting/0 => "Greetings to 0 people!"
        /// </example>
        public string Get(string id)
        {
            string message = "Greetings to " + id + " people!";
            return message;
        }
    }
}
