using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave16
    {
        public static void OpgaveRun()
        {
            //Initializes variables.
            string radius;            
            double areal;
            double omkreds;
            double radius1;            
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du beregne arealet og omkredsen på en cirkel ved hjælp af radius.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal for radius.");
            //Reads user input and uses it to set value for "radius".
            radius = Console.ReadLine();
            //Sets variable "radius1" to "double" version of "string" "radius".
            radius1 = Convert.ToDouble(radius);
            //Calculates the surface of the cirkel and sets it as value for "areal" - "Math.PI" is the value for π (called pi) and "Math.Pow" is a "raise a number to a power" command that will take the first number in the parentheses (called the base) and multiply it with it self as many times as the second number in the parentheses (called the exponent) indicates. 
            areal = Math.PI * Math.Pow (radius1, 2);
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "areal" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Arealet af cirklen er {areal}");
            //Calculates the circumference of the circle and sets it as value for "omkreds" - "Math.PI" is the value for π (called pi).
            omkreds = 2 * radius1 * Math.PI;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "omkreds"" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Omkredsen af cirklen er {omkreds}");

        }
    }
}

