using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave40
    {
        public static void OpgaveRun()
        {
            //Clears terminal screen.
            Console.Clear();

            string tast;
            
            Console.WriteLine("Velkommen til menu testen!");
            Console.WriteLine("\nTryk på 1 på tastaturet efterfulgt af Return: ");
            Console.WriteLine("\nTryk på 2 på tastaturet efterfulgt af Return: ");
            Console.WriteLine("\nTryk på 3 på tastaturet efterfulgt af Return: \n");


            tast = Console.ReadLine();


            switch (tast)

            {

                case "1":

                    Console.WriteLine("Du har trykket på 1.\nTast return");

                    break;

                case "2":

                    Console.WriteLine("Du har trykket på 2.\nTast return");

                    break;

                case "3":

                    Console.WriteLine("Du har trykket på 3.\nTast return");

                    break;

                default:

                    Console.WriteLine("Du har ikke tastet 1,2 eller 3.\nTast return");

                    break;

            }

            
        }
    }
}
