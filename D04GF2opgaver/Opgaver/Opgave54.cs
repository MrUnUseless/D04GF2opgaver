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
        public static int højde;
        public static double højdeDouble;
        public static int radius;
        public static double radiusDouble;
        public static double radiusIanden= Math.Pow(radius, 2);// radius * radius or radius in second power
        public static double rumfangafcylinder;
        

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Calculating volume of cylinder using V = πr²h (Volume = Pi * (Radius * Radius) * Height).
            //Method level setup part: Initializes and/or sets/presets variables.

            Console.Write("Indtast højde på cylinder i cm:\n");
            højde = Convert.ToInt32(Console.ReadLine());

            højdeDouble = højde;

            Console.Write("Indtast radius på cylinder i cm:\n");
            radius = Convert.ToInt32(Console.ReadLine());

            radiusDouble = radius;
            
            rumfangafcylinder = rumfang(højdeDouble, radiusDouble);
            Console.Write("\nRumfanget af cylinderen (med fem decimaler) er {0:N5} cm³", rumfangafcylinder);

            Console.WriteLine("\n\nEller med en anden kode- samme resultat:");

            //eller man kan skrive –:                 *******(Alt + 252 giver ³)****
            Console.Write("\nRumfanget af cylinderen (med fem decimaler) er {0:N5} cm³", rumfang(højdeDouble, radiusDouble));
            // da metoden jo returnerer en værdi
            Console.ReadKey();
            

        }//End method "Opgaverun".

        //**NEW METHOD**

        //Start method "rumfang".
        //Calculating volume of cylinder using V = πr²h (Volume = Pi * (Radius * Radius) * Height).
        static public double rumfang(double højderumfang, double radiusrumfang)
        {
            radiusIanden = Math.Pow(radiusrumfang, 2);
            double rumfang = Math.PI * radiusIanden * højderumfang;
            return rumfang;

        }//End method "rumfang".

    }
}
