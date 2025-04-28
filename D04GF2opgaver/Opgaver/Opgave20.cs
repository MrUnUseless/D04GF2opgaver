using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave20
    {
        public static void OpgaveRun()
        {
            //Initializes variables.            
            double tal1;
            double tal2;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("I dette program kan du beregne hvilket af de to indtastede tal der er størst.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast første tal:");
            //Reads user input and converts it to "double" and sets it as value for "tal1".
            tal1 = Convert.ToDouble(Console.ReadLine());            
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast andet tal:");
            //Reads user input and converts it to "double" and sets it as value for "tal2".
            tal2 = Convert.ToDouble(Console.ReadLine());
            //Writes empty "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line to create space between input and answer.
            Console.WriteLine();
            //Checks if numbers are identical and writes "TEXT" if so and if not moves on ("else").
            if (tal1 == tal2)
            {
                Console.WriteLine("De to tal er lige store.");
            }
            else
            {
                //Calculates which number is the bigger one and writes "TEXT" (the number) accordingly and then writes more "TEXT" (explanation).
                Console.Write(Math.Max(tal1, tal2));
                Console.WriteLine(" er det største tal.");
            }   
        }
    }
}
