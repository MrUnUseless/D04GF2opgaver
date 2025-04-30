using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave42V2
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Initializes drink amount number.
        public static int drinkamountresult;

        //Start method "Opgaverun"
        public static void OpgaveRun()
        {

            //Setup part: Initializes and/or sets/presets variables.

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

            //"do-while" loop keeps user returning to menu until user chooses to end program (finish order/bestilling) by choosing "9".
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

                //Clears console and presents menu using the "\n for spacing and the "$" combined with "{}" to call the various drink related variables.
                Console.Clear();
                Console.WriteLine("Velkommen til Drink Horama!");
                Console.WriteLine("\nHerunder følger et udvalg af vores lækre drinks- lav din bestilling så laver vi dine drinks.");
                Console.WriteLine("\nIndtast tallet ud for den drink du ønsker at bestille (efterfulgt af return):");
                Console.WriteLine($"\n 1: {drink01} til {drink01pris} kr.");
                Console.WriteLine($"\n 2: {drink02} til {drink02pris} kr.");
                Console.WriteLine($"\n 3: {drink03} til {drink03pris} kr.");
                Console.WriteLine($"\n 4: {drink04} til {drink04pris} kr.");
                Console.WriteLine($"\n 5: {drink05} til {drink05pris} kr.");
                Console.WriteLine("\nTast 9 efterfulgt af return når du er færdig og parat til at afgive din bestilling. \n");

                //Displays the current order or (in case of none) that there aren't any ("if-else").                
                if (samletpristotal != 0)
                {
                    Console.WriteLine("Din bestilling er nu:\n");
                    if (drink01antal != 0)
                    {
                        Console.WriteLine($" {drink01antal} {drink01} af ialt {drink01pristotal} kr.");
                    }
                    if (drink02antal != 0)
                    {
                        Console.WriteLine($" {drink02antal} {drink02} af ialt {drink02pristotal} kr.");
                    }
                    if (drink03antal != 0)
                    {
                        Console.WriteLine($" {drink03antal} {drink03} af ialt {drink03pristotal} kr.");
                    }
                    if (drink04antal != 0)
                    {
                        Console.WriteLine($" {drink04antal} {drink04} af ialt {drink04pristotal} kr.");
                    }
                    if (drink05antal != 0)
                    {
                        Console.WriteLine($" {drink05antal} {drink05} af ialt {drink05pristotal} kr.");
                    }
                    Console.WriteLine($"\n Total ialt: {samletpristotal} kr.");
                }

                else
                {
                    Console.WriteLine("Du har endnu ikke føjet noget til din bestilling.");
                }

                //Result part: Here the input will create some kind of result.

                /*Sets variable "tast" as user input and runs "switch (tast)" accordingly as in adding to amount of drinks or ending order.
                "DrinkAmountAsk" called and used to determine amount of drink chosen.
                "Console.ReadKey()" used for user to be able to read message before returning to menu (and thus "Console.Clear()").*/
                tast = Console.ReadLine();

                switch (tast)
                {

                    case "1":

                        Console.WriteLine($"\nHvor mange {drink01}(s) ønsker du at købe?\n");
                        DrinkAmountAsk();
                        Console.WriteLine($"\nDu har føjet {drinkamountresult} {drink01}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink01antal = drink01antal + drinkamountresult;
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.WriteLine($"\nHvor mange {drink02}(s) ønsker du at købe?\n");
                        DrinkAmountAsk();
                        Console.WriteLine($"\nDu har føjet {drinkamountresult} {drink02}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink02antal = drink02antal + drinkamountresult;                        
                        Console.ReadKey();
                        break;

                    case "3":

                        Console.WriteLine($"\nHvor mange {drink03}(s) ønsker du at købe?\n");
                        DrinkAmountAsk();
                        Console.WriteLine($"\nDu har føjet {drinkamountresult} {drink03}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink03antal = drink03antal + drinkamountresult;
                        Console.ReadKey();
                        break;

                    case "4":

                        Console.WriteLine($"\nHvor mange {drink04}(s) ønsker du at købe?\n");
                        DrinkAmountAsk();
                        Console.WriteLine($"\nDu har føjet {drinkamountresult} {drink04}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink04antal = drink04antal + drinkamountresult;
                        Console.ReadKey();
                        break;

                    case "5":

                        Console.WriteLine($"\nHvor mange {drink05}(s) ønsker du at købe?\n");
                        DrinkAmountAsk();
                        Console.WriteLine($"\nDu har føjet {drinkamountresult} {drink05}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        drink05antal = drink05antal + drinkamountresult;
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
        }//End method "Opgaverun"


        //Start method "DrinkAmountAsk"
        public static int DrinkAmountAsk()
        {
            //Presets "do-while" (amount check run) condition.
            bool InputWrongRunning = true;

            //Presets "foreach" flag, then set by result of check for non-number/cipher.
            int numberflag = 1;

            //"do-while" loop checks if input is valid. If no lets user try again. If yes returns the desired amount of the drink in question.
            do
            {
                Console.WriteLine("Indtast venligst antal (og tryk return):\n");
                string drinkamount = Console.ReadLine();

                /*Checks if "drinkamount" is empty (as in user just repeatedly pressing return) and thus incorrect.
                If so sets numberflag to 0 as to ensure the "default" (error) option.*/
                if (drinkamount.Length < 1)
                {
                    numberflag = 0;
                }

                //Demands each ("foreach") character in string "drinkamount" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                foreach (char mule in drinkamount)
                {
                    //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number/cipher (numbers/ciphers in character is from 0 to 9).
                    if (mule < '0' || mule > '9')
                    {
                        //If a character in "drinkamount" is not a number/cipher then do the following: set variable "numberflag" to 0.
                        numberflag = 0;                        
                    }
                }
                
                switch (numberflag)
                {

                    //If "numberflag" was not set to 0 (not altered as in only number(s)/cipher(s) present in user input "drinkamount") then do the following.
                    case 1:

                        //Sets variable "drinkamountresult" to integer version of "drinkamount" and sets "InputWrongRunning" to false and thus ending loop "do-while".
                        drinkamountresult = Convert.ToInt32(drinkamount);
                        InputWrongRunning = false;
                        break;

                    //If "numberflag" was set to 0 (as in a none number/cipher present in user input "drinkamount") then do the following.
                    default:

                        /*Following code block writes in terminal window that the input could not be read and how to try again.
                        Then waits for user to press any key to restart loop and sets "numberflag" to 1 before restarting.
                        If "numberflag" is not set to 1, an endless loop to "default" will run, as the only other setting of "numberflag" to 1 is above loop.*/
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();
                        numberflag = 1;
                        break;
                }                
            } while (InputWrongRunning);
            return drinkamountresult;
        } //End method "DrinkAmountAsk"        
    }
}
