using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.hello();

            Variables variables = new Variables();
            variables.exercise1();

            Decisions decisions = new Decisions();
            decisions.readLine();
            decisions.ifDecision();
            decisions.ifDecisionRefactorized();

            forIterations foriterations = new forIterations();
            foriterations.forIterators();

            Arrays arrays = new Arrays();
            arrays.reverseArray();

            MethodOverloads methodOverloads = new MethodOverloads();
            methodOverloads.methodOverloads();

            
            
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                {
                    Console.WriteLine(line);
                }
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}
