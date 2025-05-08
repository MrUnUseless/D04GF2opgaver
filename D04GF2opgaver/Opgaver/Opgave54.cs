using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave54
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Calculating volume of cylinder using V = πr²h (Volume = Pi * (Radius * Radius) * Height).
            //Method level setup part: Initializes and/or sets/presets variables.

            Console.Write("Indtast højde på cylinder i cm: ");
            int højde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast længde på kassen i cm: ");
            int længde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast bredde på kassen i cm: ");
            int bredde = Convert.ToInt32(Console.ReadLine());

            int rumfangafkassen = rumfang(højde, længde, bredde);
            Console.Write("Rumfanget af kassen er {0} cm³", rumfangafkassen);

            //eller man kan skrive – Alt + 252 giver ³
            Console.Write("Rumfanget af kassen er {0} cm³", rumfang(højde, længde, bredde));
            // da metoden jo returnerer en værdi
            Console.ReadKey();
            

        }//End method "Opgaverun".

        //**NEW METHOD**

        //Start method "rumfang".
        static public int rumfang(int h, int l, int b)
        {
            int rumfang = h * l * b;
            return rumfang;

        }//End method "rumfang".

    }
}
