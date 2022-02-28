using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01527699_W2022_Assigment2.Controllers
{
    [Route("api/J3_2011/Get/{idOne}/{idTwo}")]
    public class J3_2011Controller : ApiController
        {/// <summary>
         /// from question, integer greater than or equal 0
         /// in while loop, numOne has to be greater or equal numTwo
         /// numOne and numTwo both have to be greater or equel 0
         /// int counter = 2 because input two number, so the loop has to start with 2
         /// counter++ = 2+1
         /// </summary>
         /// <param name="idOne">input first number to int numOne </param>
         /// <param name="idTwo">input second number to int numTwo </param>
         /// <returns>coutner = the length of the sumac sequence </returns>
        public int get(int idOne, int idTwo)
        {
            int counter = 2;
            int numOne = idOne;
            int numTwo = idTwo;

            while (numOne >= numTwo && numOne >= 0 && numTwo >= 0)
            {
                int numThree = numOne - numTwo;
                numOne = numTwo;
                numTwo = numThree;
                counter++;
                    // example 120 71 49 22 27
            }
            return counter;
            
         
          
            
        }
    }
}
