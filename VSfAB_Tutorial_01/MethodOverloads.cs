using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class MethodOverloads
    {
        public void methodOverloads() 
        {
            string myValue = superSecretFormula();
            Console.WriteLine(myValue);
            Console.ReadLine();
        }


        private string superSecretFormula()
        {
            return "Hello World";
        }
    }
}
