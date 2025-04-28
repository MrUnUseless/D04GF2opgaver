using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave10
    {
        public static void OpgaveRun()
        {
            //Sets Background color
            Console.BackgroundColor = ConsoleColor.Red;
            //Sets foreground (text) color
            Console.ForegroundColor = ConsoleColor.White;
            //Following code block sets cursor position and writes a text in incremental steps (new lines) until a Danish flag is created in the centre of the terminal.
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("██████████████████████████████");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("██████████████████████████████");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 17);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 18);
            Console.WriteLine("          █████               ");
            Console.SetCursorPosition(50, 19);
            Console.WriteLine("          █████               ");            
        }
    }
}

