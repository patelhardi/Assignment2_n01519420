using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01519420.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// take a string from user and split each letter and then count one second for each letter then return total minimum second required to print a message
        /// check each letter and count secounds, if same letter appears from keyboard add 2 seconds in the count
        /// for halt message application will stop running
        /// </summary>
        /// <param name="message">take message string from user</param>
        /// <returns>return one int value with counting all seconds</returns>
        /// <example>a => 1</example>
        /// <example>dada => 4</example>
        [HttpGet]
        [Route("api/J3/CellPhone/{message}")]
        public int CellPhone(string message)
        {
            List<char> value1 = new List<char> { 'a', 'd', 'g', 'j', 'm', 'p', 't','w'};
            List<char> value2 = new List<char> { 'b', 'e', 'h', 'k', 'n', 'q', 'u', 'x' };
            List<char> value3 = new List<char> { 'c', 'f', 'i', 'l', 'o', 'r', 'v', 'y' };
            List<char> value4 = new List<char> { 's', 'z'};
            int count = 0;
            if (message != "halt")
            {
                foreach (char value in message)
                {
                    if (value1.Contains(value))
                    {
                        count += 1;
                    }
                    else if (value2.Contains(value))
                    {
                        count += 2;
                    }
                    else if (value3.Contains(value))
                    {
                        count += 3;
                    }
                    else if (value4.Contains(value))
                    {
                        count += 4;
                    } 
                }
            }
            else
            {
                System.Environment.Exit(0);
            }
            
            return count;
        }

    }
}
