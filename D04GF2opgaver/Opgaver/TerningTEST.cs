using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class TerningTEST
    {
        public static void OpgaveRun()
        {
            Random RandomObj = new Random();
            int øjne;
            do
            {
                øjne = RandomObj.Next(1, 7);
                Console.WriteLine("Terning viste: {0}", øjne);
            }
            while (øjne < 6);
            Console.ReadKey();
        }

    }
}
