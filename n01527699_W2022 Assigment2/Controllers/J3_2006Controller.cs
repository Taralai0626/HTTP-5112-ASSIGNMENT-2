using System;
using System.Linq;
using System.Web.Http;

namespace n01527699_W2022_Assigment2.Controllers
{
    public class J3_2006Controller : ApiController
    {
        [Route("api/J3_2006/Get/{id}")]
        public int get(string id)
        {
            string[] ButtonTwo = { "a", "b", "c" };
            string[] ButtonThree = { "d", "e", "f" };
            string[] ButtonFour = { "g", "h", "i" };
            string[] ButtonFive = { "j", "k", "l" };
            string[] ButtonSix = { "m", "n", "o" };
            string[] ButtonSeven = { "p", "q", "r", "s" };
            string[] ButtonEight = { "t", "u", "v" };
            string[] ButtonNine = { "w", "x", "y", "z" };
            /* string[] vs = { "AB, CD, EF", "GH, IJ, KL", "MN, O, QR" };*/

            /*String value = id; //Enter String  
                                         //Convert string to a char array.  
            string[] array = value.ToCharArray(); // Conversion to character from string */ 
           
            
            int item1 = Array.IndexOf(ButtonTwo, id);
            int item2 = Array.IndexOf(ButtonThree, id);
            int item3 = Array.IndexOf(ButtonFour, id);
            int item4 = Array.IndexOf(ButtonFive, id);
            int item5 = Array.IndexOf(ButtonSix, id);
            int item6 = Array.IndexOf(ButtonSeven, id);
            int item7 = Array.IndexOf(ButtonEight, id);
            int item8 = Array.IndexOf(ButtonNine, id);

           int itemTotal = (item1 + 1) + (item2 + 1)
                        + (item3 + 1) + (item4 + 1) + (item5 + 1) + (item6 + 1) + (item7 + 1) + (item8 + 1);

                    return itemTotal;
                
        }
            

    }
}
