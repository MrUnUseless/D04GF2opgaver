using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave21
    {
        public static void OpgaveRun()
        {
            //Initializes variables.            
            string bogstav;            
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du tjekke om du er berettiget til medlemsrabat.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Hvis du er medlem så tast j, hvis du ikke er medlem så tast n:");
            //Reads user input, converts it to lower case if not already ("ToLower()") and sets it as value for "bogstav".
            bogstav = Console.ReadLine().ToLower();
            //Checks if input is "j" and user is therefore eligible for discount. If not moves on to "else if".
            if (bogstav == "j")
            {
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
                Console.WriteLine("Som medlem er du berettiget til 10% rabat.");
            }
            //Checks if input is "n" and user is therefore not eligible for discount. If not moves on to "else".
            else if (bogstav == "n")
            {
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
                Console.WriteLine("Da du ikke er medlem er du ikke berettiget til rabat.");
            }
            //Since input is not "j" or "n" user has likely made an incorrect input and will be asked to try again.
            else
            {
                //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart program.
                Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst kun j eller n.");
                Console.WriteLine("Tryk en tast for at prøve igen!");
                Console.ReadKey();
                Opgave21.OpgaveRun();
            }
        }
    }
}
