using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01519420.Controllers
{
    public class J4Controller : ApiController
    {
        /// <summary>
        /// takes single number from user and check as per the user todo list and arrange it in a order 
        /// return string with order or message 'task not completed, going to bed'
        /// program ends with input value 
        /// </summary>
        /// <param name="taskNumber"> take one integer value at a time from a user</param>
        /// <returns>returns strings with order of task or message </returns>
        [Route("api/j4/todoList/{taskNumber}")]
        [HttpGet]
        public string todoList(int taskNumber)
        {
            return "";
        }
    }
}
