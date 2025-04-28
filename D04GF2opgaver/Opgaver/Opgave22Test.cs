using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave22Test
    {
        public static void OpgaveRun()
        {
            /*Developer notes:
            I wished to try and make it so user input could not be wrong which after a lot of trying let me to talk to Chat GPT about the problem.
            After a lt of talk and trying to avoid parse, bool and tryparse I ended up with a foreach command. Lots of trial an error later:*/

            //Initializes variables and sets one of them.
            string alder;
            int alder1;            
            int numberflag = 1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.WriteLine("Velkommen til biografens billetkontor. Her kan du tjekke prisen på din billet afhængig af din alder.");
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast din alder (brug venligst hele tal): ");
            //Sets variable "alder" according to user keyboard input.

            alder = Console.ReadLine();
            //Demands each ("foreach") character in string "alder" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
            foreach (char mule in alder)
            {
                //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number (numbers in character is from 0 to 9).
                if (mule < '0' || mule > '9')
                {
                    //If a character in "alder" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break") as no further checking is necessary.
                    numberflag = 0;
                    break;
                }
            }
            //If "numberflag" was set to 0 (as in a none number present in user input "alder") then do the following.
            if (numberflag == 0)
            {
                //Following code block until next "else" writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart program.
                Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                Console.WriteLine("Tryk en tast for at prøve igen!");
                Console.ReadKey();               
                Opgave22Test.OpgaveRun();
            }
            //If "numberflag" was not set to 0 (not altered as in only number(s) present in user input "alder") then do the following.
            else
            {
                //Sets variable "alder1" to integer version of "alder".
                alder1 = Convert.ToInt32(alder);
                //Defines and displays corresponding ticket price by going through "if else".
                if (alder1 < 18)
                    Console.WriteLine("Da du er under 18 vil din billetpris være 45 kr.");
                else if (alder1 >= 18 && alder1 < 65)
                    Console.WriteLine("Da du er mellem 18 og 65 vil din billetpris være 75 kr.");
                else
                    Console.WriteLine("Da du er 65 eller over vil din billetpris være 35 kr.");
            }
                                  
        }
    }
}
