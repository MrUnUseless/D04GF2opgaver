using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave37
    {
        //Class level setup part: Initializes and/or sets/presets variables.
        public static bool IsRunning = true;
        public static string FynBy = "odense";
        public static string Forsøg;
        public static int AntalForsøg = 0;
        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.


            do
            {
                Console.Clear();
                Console.WriteLine("Gæt en by på fyn.\nIndtast dit forsøg:");
                Forsøg = Console.ReadLine().ToLower();

                if (Forsøg == FynBy)
                {
                    AntalForsøg++;
                    Console.WriteLine($"TILLYKKE!!! Du gættede rigtig og brugte kun {AntalForsøg} forsøg.");
                    IsRunning = false;
                    Console.WriteLine("Tryk en tast");
                }

                else
                {
                    AntalForsøg++;
                    Console.WriteLine("Nix. Hvor er det bare synd for dig- prøv igen.");
                    Console.WriteLine("Tryk en tast");
                    Console.ReadKey();
                }                
            }
            while (IsRunning);




        }//End method "Opgaverun".

        //**NEW METHOD**
    }
}
