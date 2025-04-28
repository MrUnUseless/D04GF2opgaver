using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave31
    {
        public static void OpgaveRun()
        {
            //Initializes variables and pre-sets them.
            int wishtal = 0;
            int wishtalcalc = 0;
            //Clears terminal screen.
            Console.Clear();            
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.WriteLine("Velkommen til Tabel Programmet- her kan du indtaste et tal og få vist * tabellen op til 20 * for det.");
            Console.WriteLine("Indtast dit tal (brug venligst kun hele tal):");
            //Reads user input and sets it as value for string variable "wishtal".
            wishtal = Convert.ToInt32(Console.ReadLine());
            //Initializes variable "i" as integer and sets it to 1, then checks condition (if "i" is smaller or equal to 20) and if yes runs loop "for" adding 1 to value of "i" at the end of loop run and starts over at checking condition.
            for (int i = 1; i <= 20; i++)
            {
                //Calculates "wishtalcalc" - the result of current value of "i" times original user input "wishtal".
                wishtalcalc = wishtal * i;
                //Cheks if ("if") "i" is equal to or less than 9 so it ads a space before printing ("Console.WriteLine") "i", if not ("else") does not.
                if (i <= 9)
                {
                    //Writes part of table to terminal (adding space before "i" for viewing pleasure). "$" and "{}" calls variables and "\n" jumps to new line.
                    Console.WriteLine($"\n {i}   *   {wishtal}   =      {wishtalcalc}");
                }
                else
                {
                    //Writes part of table to terminal. "$" and "{}" calls variables and "\n" jumps to new line.
                    Console.WriteLine($"\n{i}   *   {wishtal}   =      {wishtalcalc}");
                }
            }
            //Tells user to press a key to finish.
            Console.WriteLine("\nTryk en tast for at afslutte");
        }
    }
}
