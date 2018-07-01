using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Paractical1
{
    /// <summary>  
    /// C# program that asks from the user for the letter of a play card. 
    /// The user input must be either J, Q, K, or A.
    /// Perform user input validation.
    /// If user input is not one of the four specified letters, your program must prompt for re-entry until
    /// a valid input is received.
    /// Once a valid letter is received, a selection statement should be used to display corresponding messages
    /// as J = Jack or Q = Queen or K = King or A = Ace
    /// Author: Faryaz
    /// </summary> 

    class MainClass
    {
        public static void Main(string[] args)
        {
            PlayCardDisplay();

        }
        static void PlayCardDisplay()
        {
            //define the variable before the loop
            string cardName = "";
            while (true)
            {
                Write("Enter letter of a play card (J, Q, K or A): ");
                cardName = ReadLine().ToLower();
                if (cardName != "j" && cardName != "q"
                    && cardName != "k" && cardName != "a")
                {
                    WriteLine("Invalid, try again.");
                }
                else
                {
                    break;//break out of the loop
                }
            }
            //With a valid colour received, do the evaluation
            //At this point, variable "colour" is guaranteed one of red, green, blue.
            switch (cardName)
            {
                case "j":
                    WriteLine("Jack.");
                    break;
                case "q":
                    WriteLine("Queen");
                    break;
                case "k":
                    WriteLine("King");
                    break;
                case "a":
                    WriteLine("Ace");
                    break;
                    //default: // Redundant default case
                    //WriteLine("Unknown letter.");
                    //break;

            }
        }
    }
}