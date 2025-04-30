using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class MichaelForklarerVariablerOgArgumenterMellemMetoder
    {
        //Example of all over accesible string?
        public static string Tobias1;

        
        public static void OpgaveRun()
        {
            int Tobias = 13;
            /*Writes result of: CW calls (and writes the result of:) "Age" which is given a start value of "Tobias" (13).
            "Age" then defines int "_age" with the value it was given ("Tobias" or 13).
            Then runs through the code where it defines int "alder" as "_age" + 25. 
            It then returns the value of "alder" (13 + 25) as the value of ("Age"(Tobias)).
            CW then writes that value (38).*/            
            
            Console.WriteLine(Age(Tobias));            
            Console.ReadKey();
        }
        static int Age(int _age)
        {
            int alder = _age + 25;
            return alder;
        }
    }
}
