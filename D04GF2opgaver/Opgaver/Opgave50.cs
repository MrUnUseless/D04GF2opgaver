using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave50
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        public static string Text1;
        public static string Text2 = "OPGAVE 47\r\nLav et program hvor man kan indtaste to tekster. " +
            "Programmet skal så fortælle hvilken tekst der er længst." +
            "\r\nOPGAVE 48\r\nLav et program hvor man indtaster en tekst og programmet fjerner alle mellemrummene fra teksten og udskriver den." +
            "  TIP! Løb teksten igennem med en løkke." +
            " Brug eksempelvis tekst.Substring(i, 1);\r\nOPGAVE 49\r\nLav et program hvor man indtaster en tekst og programmet udskriver den spejlvendt/omvendt." +
            "\r\nTIP! Løb teksten igennem med en løkke." +
            "  \r\nOPGAVE 50\r\nLav et program hvor man kan indtaste en tekst og finde ud af om denne tekst findes i den anden tekst." +
            "\r\nTIP! Tekstvariabel.Contains(søgestreng) hvor Tekstvariabel er teksten og søgestreng er den tekst du leder efter.\r\n";        
        public static bool TrueTest;
        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            Console.Clear();
            Console.WriteLine("Velkommen til hvor-er-teksten tekst programmet.\nIndtast tekst når du bliver prompted.");
            Console.WriteLine("\nIndtast tekst 1:\n");
            Text1 = Console.ReadLine();

            TrueTest = Text2.Contains(Text1);
            if (TrueTest == true)
            {
                Console.WriteLine("\nJa, teksten findes i den hemmelige tekst.");
            }
            else if (TrueTest == false)
            {
                Console.WriteLine("\nNej, teksten findes ikke i den hemmelige tekst.");
            }

            Console.WriteLine("\nDet var vel nok sjovt.\n");
            Console.WriteLine("Tryk en tast.");
            
        }//End method "Opgaverun".

    }
}
