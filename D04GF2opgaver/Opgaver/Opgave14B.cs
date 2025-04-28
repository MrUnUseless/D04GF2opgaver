using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave14B
    {
        public static void OpgaveRun()
        {
            //Initializes variables.
            string bredde;
            string højde;
            double areal;
            double omkreds;
            double bredde1;
            double højde1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du beregne arealet og omkredsen på et rektangel.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal for bredden.");
            //Reads user input and uses it to set value for "bredde".
            bredde = Console.ReadLine();
            //Sets variable "bredde1" to "double" version of "string" "bredde".
            bredde1 = Convert.ToDouble(bredde);
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal for højden.");
            //Reads user input and uses it to set value for "højde".
            højde = Console.ReadLine();
            //Sets variable "højde1" to "double" version of "string" "højde".
            højde1 = Convert.ToDouble(højde);
            //Calculates the surface of the rectangle and sets it as value for "areal".
            areal = højde1 * bredde1;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "areal" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Arealet af rektanglet er {areal}");
            //Calculates the perimeter of the rectangle and sets it as value for "omkreds".
            omkreds = 2 * (højde1 + bredde1);
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "omkreds"" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Omkredsen af rektanglet er {omkreds}");

        }
    }
}
