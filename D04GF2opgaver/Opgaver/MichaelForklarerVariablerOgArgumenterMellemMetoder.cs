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
        //
        public static string Tobias1;

        
        public static void OpgaveRun()
        {
            int Tobias = 13;
            Console.WriteLine(Age(Tobias));
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.ReadKey();
        }
        static int Age(int _age)
        {
            int alder = _age + 25;
            return alder;
        }
    }
}
