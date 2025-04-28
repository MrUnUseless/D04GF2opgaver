using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave28
    {
        public static void OpgaveRun()
        {
            //Goes through "for" loop initially setting variable "i" to 1, then checking if "i" is lower than or equal to 100 and if so running code in curly brackets and then adding 1 to "i".
            for (int i = 1; i <= 100; i++)
            {
                //Checks if "i" is less than 100 and then add a "," at the end of the written number ("i" called by "$" and "{]") for wieving pleasure.
                if (i < 100)
                    Console.Write($"{i}, ");
                //If not less than 100 it must be 100 and thus no need for "," so only writes number ("i").
                else
                    Console.Write(i);
            }            
        }
    }
}
