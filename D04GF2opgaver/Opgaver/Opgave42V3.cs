using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave42V3
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Initializes item amount result variable- the return value of the input validation check ("IntInputValidCheck()").
        public static int ItemAmountResult;

        //Start method "Opgaverun"
        public static void OpgaveRun()
        {

            //Method level setup part: Initializes and/or sets/presets variables.

            //Presets "do-while" (menu run) condition.
            bool IsRunning = true;

            //Presets user input to "empty".
            string Tast = "";

            //Sets drinks available (using array "string[] Drink").
            string[] Drink = { "Mojito", "Negroni", "Daiquiri", "Dry Martini", "Gin Fizz" };

            //Sets drink pricing (using array "int[] DrinkPris").
            int[] DrinkPris = { 90, 100, 90, 80, 90 };

            //Initializes individual drink type's amount (using array "int[] DrinkAntal").
            int[] DrinkAntal = new int[5];

            //Initializes individual drink type's total price (using array "int[] DrinkPrisTotal").
            int[] DrinkPrisTotal = new int[5];

            //Presets drink order total price.
            int SamletPrisTotal = 0;

            //Starts main loop of this method.

            //"do-while" loop keeps user returning to menu until user chooses to end program (finish order/bestilling) by choosing "9".
            do
            {
                //"do while" calculations: Calculates and sets the calculated variables.

                //Sets "DrinkPrisTotal[X]" according to price and ordered amount per drink.
                DrinkPrisTotal[0] = DrinkPris[0] * DrinkAntal[0];
                DrinkPrisTotal[1] = DrinkPris[1] * DrinkAntal[1];
                DrinkPrisTotal[2] = DrinkPris[2] * DrinkAntal[2];
                DrinkPrisTotal[3] = DrinkPris[3] * DrinkAntal[3];
                DrinkPrisTotal[4] = DrinkPris[4] * DrinkAntal[4];

                //Sets "SamletPrisTotal" to sum value of "DrinkPrisTotal[X]" ("DrinkPrisTotal[0]" + "DrinkPrisTotal[1]" + "DrinkPrisTotal[2]" + "DrinkPrisTotal[3]" + "DrinkPrisTotal[4]").
                SamletPrisTotal = DrinkPrisTotal.Sum();

                //Menu display part: Displays menu and status of order.

                //Clears console and presents menu using the "\n for spacing and the "$" combined with "{}" to call the various drink related variables.
                Console.Clear();
                Console.WriteLine("Velkommen til Drink Horama!");
                Console.WriteLine("\nHerunder følger et udvalg af vores lækre drinks- lav din bestilling så laver vi dine drinks.");
                Console.WriteLine("\nIndtast tallet ud for den drink du ønsker at bestille (efterfulgt af return):");
                Console.WriteLine($"\n 1: {Drink[0]} til {DrinkPris[0]} kr.");
                Console.WriteLine($"\n 2: {Drink[1]} til {DrinkPris[1]} kr.");
                Console.WriteLine($"\n 3: {Drink[2]} til {DrinkPris[2]} kr.");
                Console.WriteLine($"\n 4: {Drink[3]} til {DrinkPris[3]} kr.");
                Console.WriteLine($"\n 5: {Drink[4]} til {DrinkPris[4]} kr.");
                Console.WriteLine("\nTast 9 efterfulgt af return når du er færdig og parat til at afgive din bestilling. \n");

                //Displays the current order if final price is not 0 or, in case of 0, that there aren't any order yet ("if-else").                
                if (SamletPrisTotal != 0)
                {
                    Console.WriteLine("Din bestilling er nu:\n");
                    if (DrinkAntal[0] != 0)
                    {
                        Console.WriteLine($" {DrinkAntal[0]} {Drink[0]} af ialt {DrinkPrisTotal[0]} kr.");
                    }
                    if (DrinkAntal[1] != 0)
                    {
                        Console.WriteLine($" {DrinkAntal[1]} {Drink[1]} af ialt {DrinkPrisTotal[1]} kr.");
                    }
                    if (DrinkAntal[2] != 0)
                    {
                        Console.WriteLine($" {DrinkAntal[2]} {Drink[2]} af ialt {DrinkPrisTotal[2]} kr.");
                    }
                    if (DrinkAntal[3] != 0)
                    {
                        Console.WriteLine($" {DrinkAntal[3]} {Drink[3]} af ialt {DrinkPrisTotal[3]} kr.");
                    }
                    if (DrinkAntal[4] != 0)
                    {
                        Console.WriteLine($" {DrinkAntal[4]} {Drink[4]} af ialt {DrinkPrisTotal[4]} kr.");
                    }
                    Console.WriteLine($"\n Total ialt: {SamletPrisTotal} kr.");
                }

                else
                {
                    Console.WriteLine("Du har endnu ikke føjet noget til din bestilling.");
                }

                //Result part: Here the input will create some kind of result.

                /*Sets variable "tast" as user input and runs "switch (tast)" accordingly as in adding to amount of drinks or ending order.
                "IntInputValidCheck" called and used to determine amount of drink chosen.
                "Console.ReadKey()" used for user to be able to read message before returning to menu (and thus "Console.Clear()").*/
                Tast = Console.ReadLine();

                switch (Tast)
                {

                    case "1":

                        Console.WriteLine($"\nHvor mange {Drink[0]}(s) ønsker du at købe?\n");
                        IntInputValidCheck();
                        Console.WriteLine($"\nDu har føjet {ItemAmountResult} {Drink[0]}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        DrinkAntal[0] = DrinkAntal[0] + ItemAmountResult;
                        Console.ReadKey();
                        break;

                    case "2":

                        Console.WriteLine($"\nHvor mange {Drink[1]}(s) ønsker du at købe?\n");
                        IntInputValidCheck();
                        Console.WriteLine($"\nDu har føjet {ItemAmountResult} {Drink[1]}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        DrinkAntal[1] = DrinkAntal[1] + ItemAmountResult;
                        Console.ReadKey();
                        break;

                    case "3":

                        Console.WriteLine($"\nHvor mange {Drink[2]}(s) ønsker du at købe?\n");
                        IntInputValidCheck();
                        Console.WriteLine($"\nDu har føjet {ItemAmountResult} {Drink[2]}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        DrinkAntal[2] = DrinkAntal[2] + ItemAmountResult;
                        Console.ReadKey();
                        break;

                    case "4":

                        Console.WriteLine($"\nHvor mange {Drink[3]}(s) ønsker du at købe?\n");
                        IntInputValidCheck();
                        Console.WriteLine($"\nDu har føjet {ItemAmountResult} {Drink[3]}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        DrinkAntal[3] = DrinkAntal[3] + ItemAmountResult;
                        Console.ReadKey();
                        break;

                    case "5":

                        Console.WriteLine($"\nHvor mange {Drink[4]}(s) ønsker du at købe?\n");
                        IntInputValidCheck();
                        Console.WriteLine($"\nDu har føjet {ItemAmountResult} {Drink[4]}(s) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
                        DrinkAntal[4] = DrinkAntal[4] + ItemAmountResult;
                        Console.ReadKey();
                        break;

                    //This "case" differs in that "IsRunning" is set to false and thus breaks the "do-while" loop when "while" checked.
                    case "9":

                        Console.WriteLine("\nDu har trykket på 9 - din bestilling afgives.\n");
                        IsRunning = false;
                        break;

                    default:

                        Console.WriteLine("\nDu har ikke tastet 1, 2, 3, 4, 5 eller 9.\nTryk en tast for at prøve igen:");
                        Console.ReadKey();
                        break;
                }
            } while (IsRunning); //When not true ends main loop of this method.

        }//End method "Opgaverun"


        //Start method "IntInputValidCheck".
        public static int IntInputValidCheck()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Presets "do-while" (input "ItemAmount" check run) condition.
            bool InputWrongRunning = true;

            //Starts main loop of this method.

            //"do-while" loop checks if input is valid. If no lets user try again. If yes returns the number of the input item in question.
            do
            {
                //Presets "foreach"/empty flag, then possibly set to 0 by result of check for non-cipher or empty.
                int NumberFlag = 1;

                //Clears console and asks user to input desired number.
                Console.Clear();
                Console.WriteLine("Indtast venligst antal (og tryk return):\n");
                string ItemAmount = Console.ReadLine();

                /*Checks if "ItemAmount" is empty (as in user just repeatedly pressing return) and thus incorrect.
                If so sets NumberFlag to 0 as to ensure the "default" (error) option.*/
                if (ItemAmount.Length < 1)
                {
                    NumberFlag = 0;
                }

                //Demands each ("foreach") character in string "ItemAmount" to be gone through (one by one) and set as operating value for variable "Mule" which in turn is initialized as type "char" (character).
                foreach (char Mule in ItemAmount)
                {
                    //Here "Mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a cipher (ciphers in character is from 0 to 9).
                    if (Mule < '0' || Mule > '9')
                    {
                        //If a character in "ItemAmount" is not a cipher then do the following: set variable "NumberFlag" to 0.
                        NumberFlag = 0;
                    }
                }

                switch (NumberFlag)
                {

                    //If "NumberFlag" was not set to 0 but retains value 1 (not altered as in only cipher(s) and no empty present in user input "ItemAmount") then do the following.
                    case 1:

                        //Sets variable "ItemAmountResult" to integer version of "ItemAmount" and sets "InputWrongRunning" to false, thus ending loop "do-while".
                        ItemAmountResult = Convert.ToInt32(ItemAmount);
                        InputWrongRunning = false;
                        break;

                    //If "NumberFlag" was set to 0 (as in a none cipher or empty present in user input "ItemAmount") then do the following.
                    default:

                        /*Following code block writes in console window that the input could not be read and how to try again.
                        Then waits for user to press any key to restart loop.*/
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();
                        break;
                }
            } while (InputWrongRunning);//When not true ends main loop of this method.

            //Returns result to method caller.
            return ItemAmountResult;

        } //End method "IntInputValidCheck"        
    }
}
