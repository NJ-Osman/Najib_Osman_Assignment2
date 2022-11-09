using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Najib_Osman_Assignment2.Controllers
{
    /// <summary>
    /// Making the tuning instructions easier to read for users
    /// </summary>
    ///   /// <returns>Outputs the letters and how much they have gotten tighter or have loosen</returns>
    /// <param name="plus">number of times its been tighten or loosen</param>
    ///  <param name="negative">number of times its been tighten or loosen</param>
    ///  <param name="middle">number of times its been tighten or loosen</param>
    /// <example>
    /// GET: /api/Question3/harpTuning/1/20/9
    /// "AFB tighten 8"
    /// </example>
    public class Question3Controller : ApiController
    {
        public string harpTuning(int plus, int negative, int middle)
        {
             string letters = "ABCDEFGHIJKLMNOPQRST";
             int total = 9;

        for (int i = 1; i < plus; i++)
            {
                if(i == plus)
                {
                    total = total + plus;
                }
            }
        for(int j = 1; j < negative; j++)
            {
                if(j == plus)
                {
                    total = total + negative;
                }
            }
        for(int k = 1; k < middle; k++)
            {
                total = total + middle;
            }
            return letters + "tighten" + total;
        }
    }
}
