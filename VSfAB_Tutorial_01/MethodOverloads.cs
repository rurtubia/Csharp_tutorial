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
            string myValue2 = superSecretFormula(" World");
            Console.WriteLine(myValue);
            Console.ReadLine();
        }


        private string superSecretFormula()
        {
            return "Hello World";
        }

        private string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}", name);
        }
    }
}
