using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave58
    {
        public static void OpgaveRun()
        {
            //Step 1: create an array of 4? + 1 strings.

            string[] pets = { "hund", "kat", "fugl", "fisk", "søpølse" };

            // Step 2: loop with the foreach keyword. 
            foreach (string value in pets)
            {
                // Step 3: access the enumeration variable. 
                Console.WriteLine("FOREACH ITEM: " + value);
            }
            Console.ReadKey();
        }
    }
}
