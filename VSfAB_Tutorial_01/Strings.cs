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

            //Calling parameters
            string myString3 = string.Format("Make: {0} (Model:{1})", "BMW", "760li");

            //Currency format
            string myString4 = string.Format("{0:C}", 123.45);

            //Number format
            string myString5 = string.Format("{0:N}", 123456789);

            //Percentage format
            string myString6 = string.Format("{0:P}", .123);

            //Custom formats
            //the # sign is used 


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
