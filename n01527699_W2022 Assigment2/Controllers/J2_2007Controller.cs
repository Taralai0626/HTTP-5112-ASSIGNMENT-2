using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n01527699_W2022_Assigment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// upperStr would take user input to upper case, then take it into if statement
        /// to see if it matches with short form that user want to look up to.
        /// </summary>
        /// <param name="id"> take user input short form</param>
        /// <returns>if the if stament matches, it would retern the traslation, 
        /// if not, it return whatever user's input</returns>
        /// since URL is not allow to have ":", I do not know how to resolve it, 
        /// so I just continue resolving this J2 quesiton.
        [Route("api/J2_2007/Get/{id}")]
        public string get(string id)
        {
            string upperStr = id.ToUpper();
            string shortForm1 = "CU";
            string translation1 = "see you"; 
            string shortForm2 = ":-)";
            string translation2 = "I’m happy";
            string shortForm3 = ":-(";
            string translation3 = "I’m unhappy";
            string shortForm4 = ";-)";
            string translation4 = "wink";
            string shortForm5 = ":-P";
            string translation5 = "stick out my tongue";
            string shortForm6 = "(˜.˜)";
            string translation6 = "sleepy";
            string shortForm7 = "TA";
            string translation7 = "totally awesome";
            string shortForm8 = "CCC";
            string translation8 = "Canadian Computing Competition";
            string shortForm9 = "CUZ";
            string translation9 = "because";
            string shortForm10 = "TY";
            string translation10 = "thank-you";
            string shortForm11 = "YW";
            string translation11 = "you’re welcome";
            string shortForm12 = "TTYL";
            string translation12 = "talk to you later";



            if (upperStr == shortForm1)
            {
                return translation1;
            }
            else if (upperStr == shortForm2)
            {
                return translation2;
            }
            else if (upperStr == shortForm3)
            {
                return translation3;
            }
            else if (upperStr == shortForm4)
            {
                return translation4;
            }
            else if (upperStr == shortForm5)
            {
                return translation5;
            }
            else if (upperStr == shortForm6)
            {
                return translation6;
            }
            else if (upperStr == shortForm7)
            {
                return translation7;
            }
            else if (upperStr == shortForm8)
            {
                return translation8;
            }
            else if (upperStr == shortForm9)
            {
                return translation9;
            }
            else if (upperStr == shortForm10)
            {
                return translation10;
            }
            else if (upperStr == shortForm11)
            {
                return translation11;
            }
            else if (upperStr == shortForm12)
            {
                return translation12;
            }
            else
            {
                return id;
            }
        }
    }
}