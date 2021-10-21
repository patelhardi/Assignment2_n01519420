using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01519420.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// take 2 integer values from a user and return string with possible value of roll dice sum of 10  
        /// </summary>
        /// <param name="dice1">take integer value from 1 to 1000 for dice roll 1</param>
        /// <param name="dice2">take integer value from 1 to 1000 for dice roll 2</param>
        /// <returns>return string with calculating possible ways of sum 10</returns>
        /// <example>dice 1 = 6 , dice 2  = 8 => There is 5 possible way to get sum of 10</example>
        /// <example>dice 1 = 12 , dice 2  = 4 => There is 4 possible way to get sum of 10</example>
        [HttpGet]
        [Route("api/J2/DiceGame/{dice1}/{dice2}")]
        public string DiceGame(int dice1, int dice2)
        {
            int count = 0;
            if (dice1 >= 1 && dice1 <= 1000 && dice2 >= 1 && dice2 <= 1000)
            {
                for (int i = 1; i <= dice1; i++)
                {
                    for (int j = 1; j <= dice2; j++)
                    {
                        int checkSum = i + j;
                        if (checkSum == 10)
                        {
                            count = count + 1;
                        }
                    }
                }
            }
            return "There is " + count.ToString() + " possible way to get sum of 10";
        }
    }
}
