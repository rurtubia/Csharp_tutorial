using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSfAB_Tutorial_01
{
    class Decisions
    {
        public void readLine()
        {
            Console.WriteLine("Please type your name and press [Enter]");
            string userInput = "";
            userInput = Console.ReadLine();
            Console.WriteLine("Your name is " + userInput);
            Console.ReadLine();
        }

        public void ifDecision() 
        {
            Console.WriteLine("Would you prefer option 1,2, or 3");
            string userValue = Console.ReadLine();
            if (userValue == "1")
            {
                Console.WriteLine("You win!!!");
                Console.ReadLine();
            }
            else if (userValue == "2")
            {
                Console.WriteLine("You lose, but only a little!!!");
                Console.ReadLine();
            }
            else if (userValue == "3")
            {
                Console.WriteLine("You may have lost or won.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You lose. Loser");
                Console.ReadLine();
            }
        }

        public void ifDecisionRefactorized() 
        {
            Console.WriteLine("Would you prefer option 1, 2 or 3");

            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won!";
            else if (userValue == "2")
                message = "You lost";
            else if (userValue == "3")
                message = "You may have either lost or won";
            else
                message = "You lost. Loser!";

            Console.WriteLine(message);
        }

        public void ifDecisionTernary() 
        {
            Console.WriteLine("What do you want to win?");
            string userValue = Console.ReadLine();
            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}", message);
            Console.ReadLine();
        }
    }
}
