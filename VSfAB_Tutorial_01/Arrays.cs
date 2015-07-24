using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Arrays
    {
        public void arraysExplicitNumber() 
        {
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
        }

        public void arraysImplicitNumber() 
        {
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();
        }

        public void forEachStringInNames() 
        {
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

            public void reverseArray() { 
            string zig = "this is a line full of jibberish that" + 
                         "maketh not senses";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
                Console.WriteLine(zigChar);

            Console.ReadLine();
        }
    }
}
