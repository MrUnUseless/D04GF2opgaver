using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave60
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Initializes public static string "TestNumberConverted".
        public static double TestNumberConverted;
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Initializes and presets value of "Aproved" which is stop-condition for "while" loop.
            bool Approved = false;

            //Initializes "Testnumber".
            string TestNumber;

            //Following code block uses "while" loop and "try - catch" to chekck if user input is a valid number.
            while (!Approved)
            {
                Console.Clear();
                Console.WriteLine("OBS! Komma vil blive ignoreret. Ved kommatal brug punktum.");
                Console.WriteLine("\nIndtast et tal:\n");
                TestNumber = Console.ReadLine();

                try
                {
                    TestNumberConverted = Convert.ToDouble(TestNumber);
                    Approved = true;
                }

                catch
                {
                    Console.Write("Det er ikke et gyldigt tal - Tryk enter.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.Write($"Du tastede {TestNumberConverted}. Tryk enter.");
            Console.ReadKey();
            Console.Clear();

        }// "Approved = true" ends "while" loop when input is correct ("TestNumber" is a valid number).

    }
}
