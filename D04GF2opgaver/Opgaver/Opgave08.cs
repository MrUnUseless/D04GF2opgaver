using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave08
    {
        public static void OpgaveRun()
        {
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finshing the code line.
            Console.WriteLine("Kære alle. Velkommen til fest.");
            /*Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finshing the code line.
             Numbers in curly brackets are indexes which in turn refers to the numbers or text in Quotation marks which are the arguments */
            Console.WriteLine("{0} medbringer {1}. {2} medbringer {3} {4}, {5} medbringer {6} {7} og {8} medbringer {9} {10}", "Allan", "brød", "Per", 3, "tomater", "Lise", 5, "æbler", "Kim", 2, "bananer");            
        }
    }
}

