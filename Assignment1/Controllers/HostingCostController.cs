using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        //GET: localhost:xx/api/HostingCost/{id}
        /// <summary>
        /// Recieves an input number and returns 3 strings after performed calculations
        /// </summary>
        /// <param name="id">The input number which is the number of days</param>
        /// <param name="fortnightPrice">The price for 1 fortnight</param>
        /// <param name="tax">The HST tax</param>
        /// <param name="fortnightNumber">Calculated fortnight number based on user input</param>
        /// <param name="subTotalPrice">Calculated price for fornights</param>
        /// <param name="taxPrice">Calculated tax based on subtotal</param>
        /// <returns>
        /// Returns 3 strings after calculations:
        /// 1) Input devided by 14 gives the number of fortnights;
        /// 2) Number of fortnights multiplied by fortnight price (declared variable fortnightPrice) gives the subtotal price
        /// 3) Declared variable tax multiplied by fortnightPrice and by fortnightNumber gives us tax price
        /// 
        /// After calculations, returns subTotal; taxTotal; total; OR result in one string (subTotal+taxTotal+total)
        /// </returns>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/0 => “1 fortnights at $5.50/FN = $5.50 CAD”, “HST 13% = $0.72 CAD”, “Total = $6.22 CAD”
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/14 => “2 fortnights at $5.50/FN = $11.00 CAD”, “HST 13% = $1.43 CAD”, “Total = $12.43 CAD”
        /// </example>
        /// <example>
        /// GET: localhost:xx/api/HostingCost/15 => “2 fortnights at $5.50/FN = $11.00 CAD”, “HST 13% = $1.43 CAD”, “Total = $12.43 CAD”
        /// </example>
        ///

        public string Get(string id) {
            decimal fortnightPrice = 5.50;
            decimal tax = 0.13;
            int fortnightNumber = id / 14;
            int subTotalPrice = fortnightPrice * fortnightNumber;
            int taxPrice = tax * subTotalPrice;

            string subTotal = fortnightNumber+ "fortnights at $5.50/FN = $" + subTotalPrice;
            string taxTotal = " HST 13% = $" + taxPrice;
            string total = " Total = $" + subTotalPrice+taxPrice + "CAD";

            return subTotal;
            return taxTotal;
            return total;
        }
    }
}
