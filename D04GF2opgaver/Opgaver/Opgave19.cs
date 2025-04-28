using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave19
    {
        public static void OpgaveRun()
        {

            //Initializes variables.
            int alder;
            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Velkommen til kredittjek - her kan du tjekke om du er gammel nok til at få en kreditaftale.");
            //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
            Console.WriteLine("Indtast din alder:");
            //Reads user input and converts it to integer and sets it as value for "alder".
            alder = Convert.ToInt16(Console.ReadLine());
            //Uses "if - else" to check if "alder" is bigger than or equal to 18 and if so will write the "TEXT" in the next codeline. If not it will write the "TEXT" in the codeline after that.
            if (alder >= 18)
            {
                Console.WriteLine("Da du er 18 år eller derover kan du få en kreditaftale.");
            }
            else
            {
                Console.WriteLine("Da du er under 18 år kan du ikke få en kreditaftale");
            }
        }
    }
}
