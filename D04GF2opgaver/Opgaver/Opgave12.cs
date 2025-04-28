using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave12
    {
        public static void OpgaveRun()
        {
            //Initializes variables
            string kurs, USD;
            double kroner, kurs1, USD1;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast antal amerikanske dollar (USD): ");
            //Sets variable "USD" according to user keyboard input.
            USD = Console.ReadLine();
            //Sets (converts/"Parse") USD1 as the decimal ("double") version of the string variable USD.
            USD1 = double.Parse(USD);
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast kursen på 100 amerikanske dollar (USD): ");
            //Sets variable "kurs" according to user keyboard input.
            kurs = Console.ReadLine();
            //Sets (converts/"Parse") kurs1 as the decimal ("double") version of the string variable kurs.
            kurs1 = double.Parse(kurs);
            //Calculates the the exchange rate.
            kroner = USD1 * (kurs1 / 100);
            //Writes "TEXT" (including the indexes calling the variables "kurs1, euro, kroner1") in terminal at current cursor position - the "Line" part in WriteLine changes to next terminal line after finshing the code line.
            Console.WriteLine("Når kursen er {0:N2}, får du {1:N2} kroner, hvis du veksler {2:N2} amerikanske dollar (USD).", kurs1, kroner, USD1);

        }
    }
}
