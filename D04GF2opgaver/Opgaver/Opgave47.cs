using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave47
    {
        //Class level setup part: Initializes and/or sets/presets variables.
        public static string Text1;
        public static string Text2;

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            Console.Clear();
            Console.WriteLine("Velkommen til hvilken-tekst-er-længst-måler programmet.\nIndtast de to tekster når du bliver prompted.");
            Console.WriteLine("\nIndtast tekst 1:");
            Text1 = Console.ReadLine();
            Console.WriteLine("\nIndtast tekst 2:");
            Text2 = Console.ReadLine();

            if (Text1.Length > Text2.Length)
            {
                Console.WriteLine("\nTekst 1 er længst.");
            }

            else if (Text1.Length < Text2.Length)
            {
                Console.WriteLine("\nTekst 2 er længst.");
            }

            else
            {
                Console.WriteLine("\nTekst 1 og tekst 2 er lige lange.");
            }

            Console.WriteLine("\nTryk en tast for at afslutte programmet.");
            Console.ReadKey();

        }//End method "Opgaverun".

        
    }
}
