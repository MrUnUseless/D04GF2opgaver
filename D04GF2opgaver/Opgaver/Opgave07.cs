using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave07
    {
        public static void OpgaveRun()
        {
            //String defines text variables that can be used later in the program.
            string farve1 = "røde", farve2 = "blå";
            /*Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finshing the code line.
              Numbers in curly brackets are indexes which refers to the variables defined in string*/
            Console.WriteLine("Der er mange {0} æbler i den {1} skål", farve1, farve2);            
        }

    }
}

