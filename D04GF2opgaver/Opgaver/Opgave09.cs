using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave09
    {
        public static void OpgaveRun()
        {
            //Sets Background color
            Console.BackgroundColor = ConsoleColor.Red;
            //Sets foreground (text) color
            Console.ForegroundColor = ConsoleColor.Blue;
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finshing the code line.
            Console.WriteLine("Hello, World! Color Test");
            //Makes terminal do beep sound.
            Console.Beep(440, 2000);            
        }
    }
}

