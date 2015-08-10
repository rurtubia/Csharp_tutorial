using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double OriginalPrice { get; set; }

        //Constructor
        public Car()
        {
            this.Make = "Nisan";
        }

        //Overloaded constructor
        public Car(string _make, string _model, int _year, string _color)
        {
            this.Make = _make;
            this.Model = _model;
            this.Year = _year;
            this.Color = _color;
        }


        public double determineMarketValue() 
        {
            double carValue = 100.0;

            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;
            
            return carValue;
        }

        public static void myMethod() 
        { 
        
        }
    }
}
