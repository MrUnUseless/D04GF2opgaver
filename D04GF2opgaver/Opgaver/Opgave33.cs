using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave33
    {
        public static void OpgaveRun()
        {
            /* Program asks user to input age.
            If age not equal to 53 "while" loop comtinues.*/

            string Age;

            Console.Write("Indtast en passende ca. alder for opstart på kæmpe succes:\n");
            Age = Console.ReadLine();

            while (Age != "50")
            {
                Console.WriteLine("Alder skal være mere passende");
                Console.WriteLine("Prøv igen. Indtast alder\n");
                Age = Console.ReadLine();
            }
            Console.Write("Mange tak- du har helt ret.\n");
            Console.ReadKey();
        }

    }
}
