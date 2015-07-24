using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class forIterations
    {
        public void forIterators() 
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 7)
                    Console.WriteLine("seven");
                else
                    Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
