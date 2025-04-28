using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Tasteopgave03
    {
        public static void OpgaveRun()
        {            
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Indtast dit navn, afslut med Enter: ");
            //Reading input form keyboard. Input used to define string variable "navn".
            string navn = Console.ReadLine();
            //Writes "TEXT" in terminal at current cursor position.
            Console.Write("Hej med dig, ");
            //Writes value of variable "navn" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finshing the code line.
            Console.WriteLine(navn);
        }
    }
}
