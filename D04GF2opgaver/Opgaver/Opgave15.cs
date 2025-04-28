using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave15
    {
        public static void OpgaveRun()
        {
            //Initializes variables.
            string fahrenheit;            
            double fahrenheit1;
            double celsius;            
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du omregne Fahrenheit til Celsius (temperaturen angives med en decimal).");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast temperatur i Fahrenheit.");
            //Reads user input and uses it to set value for "fahrenheit".
            fahrenheit = Console.ReadLine();
            //Sets variable "fahrenheit1" to "double" version of "string" "fahrenheit".
            fahrenheit1 = Convert.ToDouble(fahrenheit);
            //Calculates the temperature and sets it as value for "celsius".
            celsius = (fahrenheit1 - 32) / 1.8;
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "celsius" is the result of the previous calculation and is called by "$" and "{}" and the value is cut to one decimal by the added ":N1".
            Console.WriteLine($"Temperaturen i Celsius er {celsius:N1}");
        }
    }
}

