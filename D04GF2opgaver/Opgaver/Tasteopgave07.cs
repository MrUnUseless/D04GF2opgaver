using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Tasteopgave07
    {
        public static void OpgaveRun()
        {
            //Initializes variables.
            int tal;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.Write("Indtast et tal mellem 10 og 40: ");
            //Reads user input and converts it to integer and sets it as value for "tal".
            tal = Convert.ToInt16(Console.ReadLine());
            //Uses "if" to check if "tal" is smaller than 10 or bigger than 40 and if so will write the "TEXT" in the next code line.
            if (tal < 10 || tal > 40)
            {
                Console.WriteLine("Du har tastet forkert");
            }
        }
    }
}
