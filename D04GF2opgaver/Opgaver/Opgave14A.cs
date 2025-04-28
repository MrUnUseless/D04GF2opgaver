using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave14A
    {
        public static void OpgaveRun()
        {
            //Initializes variables.
            string grundlinje;
            string højde;
            double areal;
            double grundlinje1;
            double højde1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du beregne arealet på en trekant.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal for grundlinjen i cm.");
            //Reads user input and uses it to set value for "grundlinje".
            grundlinje = Console.ReadLine();
            //Sets variable "grundlinje1" to "double" version of "string" "grundlinje".
            grundlinje1 = Convert.ToDouble(grundlinje);
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal for højden i cm.");            
            //Reads user input and uses it to set value for "højde".
            højde = Console.ReadLine();
            //Sets variable "højde1" to "double" version of "string" "højde".
            højde1 = Convert.ToDouble(højde);
            //Calculates the surface of the triangle and sets it as value for "areal".
            areal = 0.5 * højde1 * grundlinje1;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable areal is the result of the calculation and is called by "$" and {}
            Console.WriteLine($"Arealet af trekanten er {areal} cm².");

        }
    }
}
