using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave41B
    {
        public static void OpgaveRun()
        {
            /*Developer note: This version, though less "clean" code-wise, attempts to follow the wording of the assignment "Opgave 41" more precisely.
            Doing so by not having a "case "4":" but incorporating an if-else in the "default:".*/

            //Initializes and sets variable to "empty".
            string tast = "";

            //"while" loop keeps user returning to menu until user chooses to end program (by choosing "9").
            while (tast != "9")
            {


                //Clears console and presents menu.
                Console.Clear();
                Console.WriteLine("Velkommen til menu testen!");
                Console.WriteLine("\nTryk på 1 på tastaturet efterfulgt af Return: ");
                Console.WriteLine("\nTryk på 2 på tastaturet efterfulgt af Return: ");
                Console.WriteLine("\nTryk på 3 på tastaturet efterfulgt af Return: ");
                Console.WriteLine("\nTryk på 9 på tastaturet efterfulgt af Return for at afslutte. \n");

                /*Sets variable "tast" and runs "switch (tast)" accordingly.
                "Console.ReadKey()" used for user to read message before returning to menu (and thus "Console.Clear()").*/
                tast = Console.ReadLine();

                switch (tast)

                {

                    case "1":

                        Console.WriteLine("\nDu har trykket på 1.\nTryk en tast for at prøve igen:");
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.WriteLine("\nDu har trykket på 2.\nTryk en tast for at prøve igen:");
                        Console.ReadKey();
                        break;

                    case "3":

                        Console.WriteLine("\nDu har trykket på 3.\nTryk en tast for at prøve igen:");
                        Console.ReadKey();
                        break;
                    
                    default:

                        if (tast == "9")
                        {
                            Console.WriteLine("\nDu har trykket på 9 - programmet afsluttes.\nTryk en tast for at afslutte.");
                        }

                        else
                        {
                            Console.WriteLine("\nDu har ikke tastet 1, 2, 3, eller 9.\nTryk en tast for at prøve igen:");
                            Console.ReadKey();
                        }
                                                
                        break;
                }
            }


        }
    }
}
