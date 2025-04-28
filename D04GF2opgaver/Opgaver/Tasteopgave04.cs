using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Tasteopgave04
    {
        public static void OpgaveRun()
        {
            //Variables set to Integer.
            int tal1, tal2, resultat;
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast et tal: ");
            //Variable "tal1" is read from user input and converted to integer.
            tal1 = Convert.ToInt16(Console.ReadLine());
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast endnu et tal: ");
            //Variable "tal2" is read from user input and converted to integer.
            tal2 = Convert.ToInt16(Console.ReadLine());
            //The two user inputs are added together.
            resultat = tal1 + tal2;
            //Writes "TEXT" (including the index calling variable "resultat") in terminal at current cursor position.
            Console.Write("Resultatet bliver: {0}", resultat);
        }
    }
}
