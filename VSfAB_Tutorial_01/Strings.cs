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
            string myString7 = string.Format("Phone Number: {0:(###) ###-####}", 1234567890);

            //Concatenation
            string myString8 = "";

            for (int i = 0; i < 100; i++)
            {
                //Full version:
                //myString8 = myString8 + "--" + i.ToString();

                // += version:
                myString8 += "--" + i.ToString();
            }

            //Using StringBuilder
            StringBuilder myString9 = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString9.Append("--");
                myString9.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
