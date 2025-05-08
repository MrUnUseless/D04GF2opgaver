using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave48
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        public static string Text1;
        public static string Text2;
        public static char Text3;
        public static string Text4;
        public static int i;
        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.
                        
            Console.Clear();
            Console.WriteLine("Velkommen til hvor-er-mellemrummene tekst programmet.\nIndtast tekst når du bliver prompted.");
            Console.WriteLine("\nIndtast tekst 1:");
            Text1 = Console.ReadLine();

            for (int i = 0; i <=Text1.Length - 1; i++)
            {

                Text2 = (Text1.Substring(i, 1));
                {

                    Text3 = Convert.ToChar(Text2);

                    if (Text3 != ' ')
                    {
                        Text4 += Text3; 
                    }

                }
            }
            Console.WriteLine(Text4);
            Console.WriteLine("Tryk en tast.");
            Console.ReadKey();
        }//End method "Opgaverun".
      
    }
}
