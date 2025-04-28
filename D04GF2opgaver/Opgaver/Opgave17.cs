using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave17
    {
        public static void OpgaveRun()
        {
            //Initializes variables.
            string bredde;
            string højde;            
            double omkreds;
            double hypotenuse1;
            double hypotenuse2;
            double bredde1;
            double højde1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du beregne omkredsen på en retvinklet trekant hvis du kender højde og bredde.");
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
            //Calculates the length² of the hypotenuse (the "c" side) of the triangle and sets it as value for "hypotenuse1" - basically using the Pythagoras' Theorem of a² + b² = c² ("hypotenuse1" being the c²).
            hypotenuse1 = Math.Pow(højde1, 2) + Math.Pow(bredde1, 2);
            //Calculates the length of the hypotenuse by square rooting of "hypotenuse1" and sets it as value for "hypotenuse2".            
            hypotenuse2 = Math.Sqrt(hypotenuse1);
            //Calculates the perimeter of the tritangle and sets it as value for "omkreds".
            omkreds = hypotenuse2 + højde1 + bredde1;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "omkreds"" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Omkredsen af den retvinklede trekant er {omkreds}");

        }
    }
}

