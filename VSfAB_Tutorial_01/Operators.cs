using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Operators
    {
        /*
         * 
         *  + operator  (math and concatenation)
         *  = operator  (variable assignment)
         *  == operator (test for equality)
         *  () operator (method invocation... ex: Console.WriteLine() )
         *  .operator   (member access)
         *  
         */

        //Variables declaration
        int x, y, a, b;
        public void assignmentOperators()
        {
            //Assignmnet operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;
        }
        

        public void mathematicalOperators()
        {
            //Mathematical Operators:
            //Adition operator
            x = 3 + 4;
            //Substraction operator
            x = 4 - 3;
            //Multiplication operator
            x = 10 * 5;
            //Division operator
            x = 10 / 5;
        }

        public void evaluationOperators() 
        { 
            //Evaluation Operators:
            //Equality Operator
            if (x == y)
            {
            }

            //Greater than operator
            if (x > y)
            {
            }

            //Less than operator
            if (x < y)
            {
            }

            //Greater or equal to operator
            if (x >= y)
            {
            }

            //Less or equal to operator
            if (x <= y)
            {
            }
        }

        public void logicalOperators() 
        { 
            //Conditional AND operator
            if ((x>y) && (a>b))
            {
            }

            //Conditional OR operator
            if ((x > y) || (a > b))
            {
            }
        }

        public void ternaryIfOperator() 
        {
            //in-line conditional operator
            string message = (x > y) ? "Car" : "Boat";
        }

        public void memberAccessOperator()
        {
            //dot operator
            Console.WriteLine("Hi");
        }
    }
}
