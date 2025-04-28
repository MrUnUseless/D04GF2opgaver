using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave22
    {
        public static void OpgaveRun()
        {
            //Initializes variables
            string alder;
            int alder1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.WriteLine("Velkommen til biografens billetkontor. Her kan du tjekke prisen på din billet afhængig af din alder.");
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast din alder (brug venligst tal): ");
            //Sets variable "alder" according to user keyboard input.
            alder = Console.ReadLine();
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
