using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave26
    {
        public static void OpgaveRun()
        {
            string Hemmeligtbrugernavn = "brugernavn";
            string IkHemmeligtbrugernavn = "";
            int Hemmeligtbrugernavnflag = 0;
            string Hemmeligtpassword = "password";
            string IkHemmeligtpassword = "";
            int Hemmeligtpasswordflag = 0;
            int SpionSum = 0;

            //Writes Intro text and instruction.
            Console.WriteLine("Velkommen til det meget hemmelige program.\nIndtast brugernavn:\n");
            IkHemmeligtbrugernavn = Console.ReadLine();
            Console.WriteLine("\nIndtast password:\n");
            IkHemmeligtpassword = Console.ReadLine();

            if (IkHemmeligtbrugernavn == Hemmeligtbrugernavn)
            {
                Hemmeligtbrugernavnflag = 1;
            }

            if (IkHemmeligtpassword == Hemmeligtpassword)
            {
                Hemmeligtpasswordflag = 1;
            }

            SpionSum = Hemmeligtbrugernavnflag + Hemmeligtpasswordflag;

            if (SpionSum == 2)
            {
                Console.WriteLine("\nWauw TILLYKKE! Du er meget hemmelig.\nDu har nu adgang til systemet.");
            }

            else
            {
                Console.WriteLine("\nHa Ha du er ikke hemmelig nok og har ikke adgang til systemet.");
            }

            Console.WriteLine("\nTryk enter for at afslutte.");
            Console.ReadKey();
        }
    }
}
