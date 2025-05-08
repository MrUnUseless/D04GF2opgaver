using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    internal class Opgave44
    {
        public static string menuvalg = "";
        //Class level setup part: Initializes and/or sets/presets variables.

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.


            Console.Clear();
            Console.WriteLine("Velkommen til areal beregnings programmet- husk at indtaste i centimeter (cm).\n");
            Console.WriteLine("Vælg det ønskede objekt til beregning:\n");
            Console.WriteLine("Tast 1 for rektangel.\n");
            Console.WriteLine("Tast 2 for Cirkel.\n");
            Console.WriteLine("Tast 3 for retvinklet trekant.\n");
            Console.WriteLine("Tast 9 for at afslutte programmet.\n");
            menuvalg = Console.ReadLine();

            switch (menuvalg)
            {

                case "1":
                    
                    ArealBeregnerRektangel();
                    break;

                case "2":
                    
                    ArealBeregnerCirkel();
                    break;

                case "3":
                    
                    ArealBeregnerTrekant();
                    break;

                case "9":

                    Console.WriteLine("\nDu har trykket på 9 - programmet ophører.\n");                    
                    break;

                default:

                    Console.WriteLine("\nDu har ikke tastet 1, 2, 3 eller 9.\nTryk en tast for at prøve igen:");
                    Console.ReadKey();
                    break;
            }

        }//End method "Opgaverun".

        //**NEW METHOD**


        //Start method "ArealBeregnerRektangel".
        public static void ArealBeregnerRektangel()                    
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
            Console.WriteLine("I dette program kan du beregne arealet på et rektangel.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal i cm for bredden.");
            //Reads user input and uses it to set value for "bredde".
            bredde = Console.ReadLine();
            //Sets variable "bredde1" to "double" version of "string" "bredde".
            bredde1 = Convert.ToDouble(bredde);
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast tal i cm for højden.");
            //Reads user input and uses it to set value for "højde".
            højde = Console.ReadLine();
            //Sets variable "højde1" to "double" version of "string" "højde".
            højde1 = Convert.ToDouble(højde);
            //Calculates the surface of the rectangle and sets it as value for "areal".
            areal = højde1 * bredde1;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "areal" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Arealet af rektanglet er {areal} cm²");


        }//End method "ArealBeregnerRektangel".


        //**NEW METHOD**


        //Start method "ArealBeregnerCirkel".
        public static void ArealBeregnerCirkel()
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
            Console.WriteLine("Indtast tal i cm for radius.");
            //Reads user input and uses it to set value for "radius".
            radius = Console.ReadLine();
            //Sets variable "radius1" to "double" version of "string" "radius".
            radius1 = Convert.ToDouble(radius);
            //Calculates the surface of the cirkel and sets it as value for "areal" - "Math.PI" is the value for π (called pi) and "Math.Pow" is a "raise a number to a power" command that will take the first number in the parentheses (called the base) and multiply it with it self as many times as the second number in the parentheses (called the exponent) indicates. 
            areal = Math.PI * Math.Pow(radius1, 2);
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "areal" is the result of the previous calculation and is called by "$" and "{}".
            Console.WriteLine($"Arealet af cirklen er {areal}cm²");

        }//End method "ArealBeregnerCirkel".


        //**NEW METHOD**


        //Start method "ArealBeregnerTrekant".
        public static void ArealBeregnerTrekant()
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
            areal = 0.5 * højde1* grundlinje1;
        //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable areal is the result of the calculation and is called by "$" and {}
        Console.WriteLine($"Arealet af trekanten er {areal} cm².");

        }//End method "ArealBeregnerTrekant".




    }
}
