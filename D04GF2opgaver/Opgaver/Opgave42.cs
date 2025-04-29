using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave42
    {
        public static void OpgaveRun()
        {

            //Setup part: Initializes and sets/presets variables.

            //Presets "do-while" (menu run) condition.
            bool IsRunning = true;
            
            //Presets user input to "empty".
            string tast = "";

            //Sets drinks available.
            string drink01 = "Mojito";
            string drink02 = "Negroni";
            string drink03 = "Daiquiri";
            string drink04 = "Dry Martini";
            string drink05 = "Gin Fizz";

            //Sets drink pricing.
            int drink01pris = 90;
            int drink02pris = 100;
            int drink03pris = 90;
            int drink04pris = 80;
            int drink05pris = 90;

            //Presets drink number.
            int drink01antal = 0;
            int drink02antal = 0;
            int drink03antal = 0;
            int drink04antal = 0;
            int drink05antal = 0;

            //Presets individual drink total price.
            int drink01pristotal = 0;
            int drink02pristotal = 0;
            int drink03pristotal = 0;
            int drink04pristotal = 0;
            int drink05pristotal = 0;

            //Presets drink total price.
            int samletpristotal = 0;

            //Start run part: Starts main loop.

            //"do-while" loop keeps user returning to menu until user chooses to end program (bestilling) by choosing "9".
            do
            {
                //"do while" calculations: Calculates and sets the calculated variables.

                //Sets "drink01-05pristotal" according to price and ordered amount per drink.
                drink01pristotal = drink01pris * drink01antal;
                drink02pristotal = drink02pris * drink02antal;
                drink03pristotal = drink03pris * drink03antal;
                drink04pristotal = drink04pris * drink04antal;
                drink05pristotal = drink05pris * drink05antal;

                //Sets "samletpristotal" to sum value of "drink01-05pristotal".
                samletpristotal = drink01pristotal + drink02pristotal + drink03pristotal + drink04pristotal + drink05pristotal;

                //Menu display part: Displays menu and status of order.

                //Clears console and presents menu using the "\n for spacing and the "$" combined with "{}" to call the drink variables.
                Console.Clear();
                Console.WriteLine("Velkommen til Drink Horama!");
                Console.WriteLine("\nHerunder følger et udvalg af vores lækre drinks- lav din bestilling så laver vi dine drinks.");
                Console.WriteLine("\nIndtast tallet ud for den drink du ønsker at bestille (efterfulgt af return):");
                Console.WriteLine($"\n 1: {drink01} til {drink01pris} kr.");
                Console.WriteLine($"\n 2: {drink02} til {drink02pris} kr.");
                Console.WriteLine($"\n 3: {drink03} til {drink03pris} kr.");
                Console.WriteLine($"\n 4: {drink04} til {drink04pris} kr.");
                Console.WriteLine($"\n 5: {drink05} til {drink05pris} kr.");
                Console.WriteLine("\nTast 9 efterfulgt af return for at afgive din bestilling. \n");

                //Displays the current order or (in case of none) that there aren't any ("if-else").                
                if (samletpristotal != 0)
                {
                    Console.WriteLine("Din bestilling er nu:\n");
                    Console.WriteLine($" {drink01antal} {drink01} af ialt {drink01pristotal} kr.");
                    Console.WriteLine($" {drink02antal} {drink02} af ialt {drink02pristotal} kr.");
                    Console.WriteLine($" {drink03antal} {drink03} af ialt {drink03pristotal} kr.");
                    Console.WriteLine($" {drink04antal} {drink04} af ialt {drink04pristotal} kr.");
                    Console.WriteLine($" {drink05antal} {drink05} af ialt {drink05pristotal} kr.");
                    Console.WriteLine($"\n Total ialt: {samletpristotal} kr.");    
                }

                else
                {
                    Console.WriteLine("Du har endnu ikke føjet noget til din bestilling.");
                }

                //Result part: Here the input will create some kind of result.

                /*Sets variable "tast" as user input and runs "switch (tast)" accordingly as in adding to amount of drink or ending order.
                "Console.ReadKey()" used for user to read message before returning to menu (and thus "Console.Clear()").*/
                tast = Console.ReadLine();

                switch (tast)

                {

                    case "1":

                        Console.WriteLine($"\nDu har føjet en {drink01} til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink01antal = drink01antal + 1;
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.WriteLine($"\nDu har føjet en {drink02} til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink02antal = drink02antal + 1;
                        Console.ReadKey();
                        break;

                    case "3":

                        Console.WriteLine($"\nDu har føjet en {drink03} til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink03antal = drink03antal + 1;
                        Console.ReadKey();
                        break;

                    case "4":

                        Console.WriteLine($"\nDu har føjet en {drink04} til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink04antal = drink04antal + 1;
                        Console.ReadKey();
                        break;

                    case "5":

                        Console.WriteLine($"\nDu har føjet en {drink05} til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink05antal = drink05antal + 1;
                        Console.ReadKey();
                        break;
                    
                    //This "case" differs in that "IsRunning" is set to false and thus breaks the "do-while" loop.
                    case "9":

                        Console.WriteLine("\nDu har trykket på 9 - din bestilling afgives.\n");
                        IsRunning = false;
                        break;

                    default:

                        Console.WriteLine("\nDu har ikke tastet 1, 2, 3, 4, 5 eller 9.\nTryk en tast for at prøve igen:");
                        Console.ReadKey();
                        break;
                }
            } while (IsRunning);
        }
    }
}
