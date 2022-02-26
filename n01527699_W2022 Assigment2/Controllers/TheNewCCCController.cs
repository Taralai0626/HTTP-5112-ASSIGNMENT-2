using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01527699_W2022_Assigment2.Controllers
{   
   
    public class TheNewCCCController : ApiController
    {
        /// <summary>
        /// take user's choice for each category, it would find the choice in the each array.
        /// </summary>
        /// <param name="burgerId">differnt burger calories in the array</param>
        /// <param name="drinkId">differnt drink calories in the array</param>
        /// <param name="sideId">differnt side calories in the array</param>
        /// <param name="dessertId">differnt desserts calorie in the array</param>
        /// <returns>since user choice number starts with 1 and array starts with 0
        /// when user input the number should minus 1 then take it into array to
        /// find the choice and return it.</returns>
        [Route("api/TheNewCCC/Get/{burgerId}/{drinkId}/{sideId}/{dessertId}")]
      
        public string Get(int burgerId, int drinkId, int sideId, int dessertId)
        {
            int[] burger = { 461, 431, 420, 0 };
            int[] drink = { 130, 160, 118, 0};
            int[] side = { 100, 57, 70, 0};
            int[] dessert = { 167, 266, 75, 0 };

            return "Your total calorie count is " + (burger[burgerId - 1] + drink[drinkId - 1] + side[sideId - 1] + dessert[dessertId - 1]);

        
        }
    }
}
