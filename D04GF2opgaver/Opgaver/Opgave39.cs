using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave39
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Start method "Opgaverun".        
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.
            string Hemmeligtbrugernavn = "brugernavn";
            string IkHemmeligtbrugernavn = "";
            int Hemmeligtbrugernavnflag = 0;
            string Hemmeligtpassword = "password";
            string IkHemmeligtpassword = "";
            int Hemmeligtpasswordflag = 0;
            int SpionSum = 0;
            bool LyverSpion = true;
            int TryCounter = 0;


            while (LyverSpion)
            {
                TryCounter++;
                if (TryCounter > 5)
                {
                    LyverSpion = false;
                    Console.WriteLine("Alarm! Du har udløst alarmen, kontoen er spærret og du har ikke flere forsøg.\n");
                    Console.WriteLine("Tryk en tast for at afslutte.");
                }
                else
                { 
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
                        Console.WriteLine("C:DIR-Farfars sexede billeder");
                        LyverSpion = false;
                    }

                    else
                    {
                        Console.WriteLine("\nHa Ha du er ikke hemmelig nok og har ikke adgang til systemet.");
                        Console.Clear();
                    }
                                   
                }
            }
        }
    }//End method "Opgaverun"    
}

