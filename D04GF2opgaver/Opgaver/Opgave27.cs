using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave27
    {
        public static void OpgaveRun()
        {
            //Instructs user.
            Console.WriteLine("Velkommen til kan-du-få-rabat programmet!\nHvis du køber for mere end tusind kroner kan du få rabat.");
            Console.WriteLine("\nHvor mange kroner køber du for?");
            string StringErDetNok = Console.ReadLine();
            int IntErDetNok = Convert.ToInt32(StringErDetNok);
            //Hvis man køber for MERE end 1000 dkk.
            if (IntErDetNok > 1000)
            {            
                Console.WriteLine("Hurrah du kan få rabat- hele 5 %");
                double MedStorRabat = (IntErDetNok * 0.95);
                Console.WriteLine($"Pris med rabat: {MedStorRabat} kr.");
            }

            else
            {
                Console.WriteLine($"Du har været for nærig- du får ikke rabat din gnier.\nDu må betale den fulde pris af {IntErDetNok} kr.");
            }
            Console.WriteLine("Tryk en tast!");
        }
    }
}
