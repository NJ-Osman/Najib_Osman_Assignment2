using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Najib_Osman_Assignment2.Controllers
{
    public class Question2Controller : ApiController
    {
        /// <summary>
        /// Finds out how many times the two dice numbers rolled can go into the sum 10
        /// </summary>
        /// <returns>The output of the number of ways the two dice numbers landed on to get the sum of 10.</returns>
        /// <param name="m">Roll Dice 1</param>
        /// <param name="n">Roll Dice 2</param>
        /// <example>
        /// GET: /api/Question2/RollTheDice/6/8
        /// "There are 5 total ways to get the sum 10."
        /// </example>
        [Route("api/Question2/RollTheDice/{m}/{n}")]
        [HttpGet]
        public string RollTheDice(int m, int n)
        {
            int total = 10;
            string key = "success";
            List<string> success = new List<string> {};

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == total)
                    {
                        success.Add(key);
                    }
                }
            }
            return "There are " + success.Count + " total ways to get the sum " + total + ".";
        }
    }
}