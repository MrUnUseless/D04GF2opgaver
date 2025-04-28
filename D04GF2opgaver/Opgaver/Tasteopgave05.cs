using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Tasteopgave05
    {
        public static void OpgaveRun()
        {
            //Initializes variables
            string kurs, kroner;
            double euro, kurs1, kroner1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast antal kroner: ");
            //Sets variable "kroner" according to user keyboard input.
            kroner = Console.ReadLine();
            //Sets (converts/"Parse") kroner1 as the decimal ("double") version of the string variable kroner.
            kroner1 = double.Parse(kroner);
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast kursen på 100 Euro: ");
            //Sets variable "kurs" according to user keyboard input.
            kurs = Console.ReadLine();
            //Sets (converts/"Parse") kurs1 as the decimal ("double") version of the string variable kurs.
            kurs1 = double.Parse(kurs);
            //Calculates the the exchange rate.
            euro = kroner1 / (kurs1 / 100);
            //Writes "TEXT" (including the indexes calling the variables "kurs1, euro, kroner1") in terminal at current cursor position - the "Line" part in WriteLine changes to next terminal line after finshing the code line.
            Console.WriteLine("Når kursen er {0:N2}, får du {1:N2} Euro, hvis du veksler {2:N2} danske kroner.", kurs1, euro, kroner1);

        }
    }
}
