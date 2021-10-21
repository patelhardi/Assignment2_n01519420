using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_n01519420.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// take 4 interger values from a user and return string. calculting calories and return total calories
        /// List<int> display list of calories in the index
        /// if-else statement check for user input values must be between 1 and 4
        /// </summary>
        /// <param name="burgerChoice">Take integer user value for burger</param>
        /// <param name="drinkChoice">Take integer user value for drink</param>
        /// <param name="sideorderChoice">Take integer user value for sideorder</param>
        /// <param name="dessertChoice">Take integer user value for dessert</param>
        /// <returns>Return total calories as per the user input value choice</returns>
        /// <example>api/j1/menu/4/4/4/4 -> your total calories count is: 0</example>
        /// <example>api/j1/menu/1/2/3/4 -> your total calories count is: 691</example>"
        [HttpGet]
        [Route("api/J1/Menu/{burgerChoice}/{drinkChoice}/{sideorderChoice}/{dessertChoice}")]
        public string Menu(int burgerChoice, int drinkChoice, int sideorderChoice, int dessertChoice)
        {
            List<int> burgerCalories = new List<int> { 461, 431, 420, 0 };
            List<int> drinkCalories = new List<int> { 130, 160, 118, 0 };
            List<int> sideorderCalories = new List<int> { 100, 57, 70, 0};
            List<int> dessertCalories = new List<int> { 167, 266, 75, 0};

            if (burgerChoice >= 1 && burgerChoice <= 4 && drinkChoice >= 1 && drinkChoice <= 4 && sideorderChoice >= 1 && sideorderChoice <= 4 && dessertChoice >= 1 && dessertChoice <= 4)
            {
                int burger = burgerCalories[burgerChoice - 1];
                int drink = drinkCalories[drinkChoice - 1];
                int sideorder = sideorderCalories[sideorderChoice - 1];
                int dessert = dessertCalories[dessertChoice - 1];

                int totalCalories = burger + drink + sideorder + dessert;
                return "Your Total Calories count is: " + totalCalories.ToString();
            }
            else
            {
                return "Please select numbers between 1 and 4";
            }
        }
    }
}
