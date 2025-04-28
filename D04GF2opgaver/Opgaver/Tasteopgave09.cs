using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Tasteopgave09
    {
        public static void OpgaveRun()
        {            
            string type;
            double pris = 0;
            Console.WriteLine("Indtast om du vil købe en stor eller lille softice: ");
            // "Stor" eller "Lille" bliver lagt i variablen type som små bogstaver
            type = Console.ReadLine().ToLower();
            if (type == "stor") pris = 8;
            if (type == "lille") pris = 5;
            Console.WriteLine("Prisen for en {0} softice bliver {1} kr. ", type, pris);            
        }
    }
}
