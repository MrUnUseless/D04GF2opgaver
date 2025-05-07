using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave35
    {
        //Class level setup part: Initializes and/or sets/presets variables.
        public static int øjenåbner = 0;
        public static int øjne;
        public static int øjentæller01;
        public static int øjentæller02;
        public static int øjentæller03;
        public static int øjentæller04;
        public static int øjentæller05;
        public static int øjentæller06;

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Random OBJ defined- in a way set like a "List" without fixed size.
            Random RandomObj = new Random();
           

            do
            {
                øjenåbner++;
                øjne = RandomObj.Next(1, 7);

                if (øjne == 1)
                    øjentæller01++; //= øjentæller01 + 1;

                else if (øjne == 2)                
                    øjentæller02++;
                
                else if (øjne == 3)
                    øjentæller03++;

                else if (øjne == 4)
                    øjentæller04++;

                else if (øjne == 5)
                    øjentæller05++;

                else if (øjne == 6)
                    øjentæller06++;
            }
            while (øjenåbner < 1001);

            Console.WriteLine($"Terning viste: {øjentæller01} Ettere");
            Console.WriteLine($"Terning viste: {øjentæller02} Toere");
            Console.WriteLine($"Terning viste: {øjentæller03} Treere");
            Console.WriteLine($"Terning viste: {øjentæller04} Fiere");
            Console.WriteLine($"Terning viste: {øjentæller05} Femere");
            Console.WriteLine($"Terning viste: {øjentæller06} Seksere");
            Console.ReadKey();
        }

    }
}
