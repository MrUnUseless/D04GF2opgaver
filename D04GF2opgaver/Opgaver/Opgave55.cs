using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave55
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            
            
            Console.Write("Indtast højde på trekanten i cm: ");
            int højde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast grundlinje på trekanten i cm: ");
            int grundlinje = Convert.ToInt32(Console.ReadLine());

            //Du kan skrive sådan 
            double areal = Matematik.areal(højde, grundlinje);
            Console.WriteLine("Rumfanget af kassen er {0:N1} cm³", areal);

            //eller du kan skrive
            Console.WriteLine("Rumfanget af kassen er {0:N1} cm³", Matematik.areal(højde, grundlinje));
            // da metoden jo returnerer en værdi
            Console.ReadKey();

        }//End method "Opgaverun".

        //**NEW CLASS**

        public class Matematik
        {
                       
            static public double areal(int h, int g)
            {
                int rumfang = h * g / 2;
                return rumfang;
            }

            static public double rumfang(double højderumfang, double radiusrumfang)// Circle Volume calculation
            {
                double radiusIanden = Math.Pow(radiusrumfang, 2);// radius * radius or radius in second power                
                double rumfang = Math.PI * radiusIanden * højderumfang;
                return rumfang;

            }//End method "rumfang".
            // på dette niveau tilføjer du flere metoder
            // her.....
        }
        //End Class "Matamatik".

        
    }
}
