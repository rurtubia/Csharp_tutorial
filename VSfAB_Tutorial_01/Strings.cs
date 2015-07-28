using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Strings
    {
        public void strings ()
        {
            //backslash error:
            //string myString = "Go to your c:\drive";

            //double quotation mark error:
            //string myString2 = "My "so called" life";

            //corrected version:
            string myString2 = "My \"so called\" life";

            string myString = string.Format("{0}!", "Bonzai");

            string myString3 = string.Format();

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
