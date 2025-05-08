using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave53
    {
        //Class level setup part: Initializes and/or sets/presets variables.
        public static string Text1;
        public static string Text2;
        public static string rød = "";
        public static string blå = "";
        public static string grøn = "";
        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.


            Console.Clear();
            Console.WriteLine("Her kan du indtaste en tekst og få vist den i en af tre farver:\n");
            Console.WriteLine("Indtast teksten (afslut med return):\n");

            Text1 = Console.ReadLine();

            Console.WriteLine("Indtast farven- du kan vælge mellem rød, blå og grøn (afslut med return):\n");

            Text2 = Console.ReadLine().ToLower();


            Skriv(Text1, Text2);


        }//End method "Opgaverun".

        //**NEW METHOD**

        //Start method "Skriv".
        public static void Skriv(string text, string color)
        {
            Console.Clear();

            if (color == "rød")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            else if (color == "blå")
            {
                Console.ForegroundColor = ConsoleColor.Blue;

            }
            else if (color == "grøn")
            {
                Console.ForegroundColor = ConsoleColor.Green;

            }
            else
            {
                Console.WriteLine("Du kunne ikke finde ud af at taste rigtigt- det var synd.\n" );
            }

                Console.WriteLine(text);

        }//End method "Skriv".

        


    }
}
