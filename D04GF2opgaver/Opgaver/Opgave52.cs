using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    internal class Opgave52
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        public static String StringAmountIn;
        public static double AmountValid = 0;
        public static double AmountOut = 0;

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.


            Console.Clear();
            Console.WriteLine("Velkommen til moms til-lægger programmet!\nHer kan du få tillagt momsen på et beløb.");
            Console.WriteLine("Tryk en tast for at gå til indtastnings modulet.");
            Console.ReadKey();

            Calculation();
                        
        }//End method "Opgaverun".

        //**NEW METHOD**

        //Start method "Calculation".

        public static void Calculation()
        {
            //Method level setup part: Initializes and/or sets/presets variables.            

            //Initializes and presets value of "Aproved" which is stop-condition for "while" loop.
            bool Approved = false;
                        
            //Following code block uses "while" loop and "try - catch" to chekck if user input is a valid number.
            while (!Approved)
            {
                Console.Clear();                
                Console.WriteLine("OBS! Komma vil blive ignoreret. Ved kommatal brug punktum.");
                Console.WriteLine("\nIndtast beløb til moms pålæggelse:\n");
                StringAmountIn = Console.ReadLine();

                try
                {
                    AmountValid = Convert.ToDouble(StringAmountIn);
                    Approved = true;
                }

                catch
                {
                    Console.Write("Det er ikke et gyldigt tal - Tryk enter.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            AmountOut = AmountValid * 1.25;

            Console.Write($"Du indtastede {AmountValid}.\nBeløb med moms er {AmountOut}.\nTryk enter for at afslutte.");
            
        }


    }//End method "Calculation".
}
