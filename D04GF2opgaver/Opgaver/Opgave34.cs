using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave34
    {
        public static void OpgaveRun()
        {
            Random RandomObj = new Random();
            int øjenåbner = 0;
            int øjne;
            do
            {
                øjenåbner++;
                øjne = RandomObj.Next(1, 7);
                Console.WriteLine("Terning viste: {0}", øjne);
            }
            while (øjenåbner < 101);
            Console.ReadKey();
        }

    }
}
