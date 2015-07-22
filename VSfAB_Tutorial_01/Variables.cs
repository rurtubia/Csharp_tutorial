using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Variables
    {
        public void exercise1()
        {
            //Initialization
            int x;
            int y;

            //Asignment
            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();

            string myFirstName;
            myFirstName = "Randy";
            Console.WriteLine(myFirstName);
            Console.ReadLine();

            //When we declare variables with the keyword 'var', we need 
            //to initialize the variable immediately with a certain value.
            var myCountry = "Chile";

            Console.WriteLine(myCountry);
            Console.ReadLine();

            //Data convertion
            
            //Implicit
            int z = 7;
            string a = "b";
            string implicitConversion = z + a;
            Console.WriteLine(implicitConversion);
            Console.ReadLine();

            //using toString()
            string toStringConversion = z.ToString() + y;
            Console.WriteLine(toStringConversion);
            Console.ReadLine();

            //Explicit
            string five = "5";
            int parseConversion = z + int.Parse(five);
            Console.WriteLine(parseConversion);
            Console.ReadLine();
        }
    }
}
