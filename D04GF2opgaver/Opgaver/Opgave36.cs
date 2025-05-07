using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave36
    {
        /*This program checks if input number is equal to or smaller than 0.
         * If so instructs user to try again until number bigger than 0 (breathtaking action).*/
        public static void OpgaveRun()
        {
            int tal;
            do
            {
                Console.Write("Indtast et positivt tal: ");
                tal = Convert.ToInt32(Console.ReadLine());
                if (tal <= 0)
                {
                    Console.WriteLine("Du skal taste et tal større end 0");
                    Console.Write("Tryk Enter");
                    Console.ReadKey();
                }
            } while (tal <= 0);

            Console.Write("Inddata er godkendt");
            Console.ReadKey();
        }

    }
}
