using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace Najib_Osman_Assignment2.Controllers
{
    public class Question1Controller : ApiController
    {
        /// <summary>
        /// Adds up the total calories the user selets from one of each food items
        /// </summary>
        /// <returns>The output of the four food sample calories</returns>
        /// <param name="burger">food sample that contains the amonut of calories inside that specific food</param>
        /// <param name="drink">food sample that contains the amonut of calories inside that specific food</param>
        /// <param name="side">food sample that contains the amonut of calories inside that specific food</param>
        /// <param name="dessert">food sample that contains the amonut of calories inside that specific food</param>
        /// <example>
        /// GET: /api/Question1/CanadianCalorieCounting/2/3/4/1
        /// "Your total calorie count is 716" 
        /// </example>
        [Route("api/Question1/CanadianCalorieCounting/{burger}/{drink}/{side}/{dessert}")]
        [HttpGet]
        public string CanadianCalorieCounting(int burger, int drink, int side, int dessert)
        {

            int total = 0;

            if (burger == 1)
            {
                total = total + 461;
            }
            else if (burger == 2)
            {
                total = total + 431;
            }
            else if (burger == 3)
            {
                total = total + 420;
            }
            else if (burger == 4)
            {
                total = total + 0;
            }
            if (drink == 1)
            {
                total = total + 130;
            } else if(drink == 2)
            {
                total = total + 160;
            } else if(drink == 3)
            {
                total = total + 118;
            } else if(drink == 4)
            {
                total = total + 0;
            }
            if (side == 1)
            {
                total = total + 100;
            }
            else if (side == 2)
            {
                total = total + 57;
            }
            else if (side == 3)
            {
                total = total + 70;
            }
            else if (side == 4)
            {
                total = total + 0;
            }
            if (dessert == 1)
            {
                total = total + 167;
            }
            else if (dessert == 2)
            {
                total = total + 266;
            }
            else if (dessert == 3)
            {
                total = total + 75;
            }
            else if (dessert == 4)
            {
                total = total + 0;
            }
            return "Your total calorie count is " + total;
        }
    }
}
