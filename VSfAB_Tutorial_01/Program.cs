﻿using System;
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

            Strings strings = new Strings();
            strings.strings();

            Datetimes dt = new Datetimes();
            dt.dateTimeToString();


            Car myNewCar = new Car();
            //Setting properties
            myNewCar.Make = "Kia";
            myNewCar.Model = "Picanto";
            myNewCar.Year = 2014;
            myNewCar.Color = "White";
            //Getting properties
            Console.WriteLine("{0},{1},{2}",myNewCar.Make, myNewCar.Model, myNewCar.Color);

            double marketValueOfCar = determineMarketValue(myNewCar);

            Console.ReadLine();

            Console.WriteLine("Car's value: {0:C}", myNewCar.determineMarketValue());

            Console.ReadLine();

            Car mySecondCar = new Car("Tesla", "Model T", 2014, "black");

            //Static methods can be invoked without initializing the class:
            Car.myMethod();


        }
        
            //Using code from a class
            private static double determineMarketValue(Car _car)
            {
                double carValue = 100.0;
                return carValue;
            }

        
        
    }
}
