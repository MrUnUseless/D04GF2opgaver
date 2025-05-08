using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave45
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Presets user input to "empty".
        public static string Tast = "";

        //Presets caller for-user print to "empty".
        public static string IIValidCheckCallerPrint = "";

        //Sets Cirkusbilleter available (using array "string[] CirkusBillet").
        public static string[] CirkusBillet = { "Blå ", "Rød ", "Gul ", "Lilla"};

        //Sets Cirkusbillet pricing (using array "int[] CirkusBilletPris").
        public static int[] CirkusBilletPris = {190, 250, 280, 320};

        //Initializes individual Cirkusbillet type's amount (using array "int[] CirkusBilletAntal").
        public static int[] CirkusBilletAntal = new int[4];

        //Initializes individual Cirkusbillet type's total price (using array "int[] CirkusBilletPrisTotal").
        public static int[] CirkusBilletPrisTotal = new int[4];

        //Presets Cirkusbillet order total price.
        public static int SamletPrisTotal = 0;

        //Sets variables for possible use in console screen position.
        public static int ScreenCenterX = Console.WindowWidth / 2;

        public static int ScreenCenterY = Console.WindowHeight / 2;

        //Initializes item amount result variable- the return value of the input validation check ("IntInputValidCheck()").
        public static int ItemAmountResult;

        //Start method "Opgaverun"
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Presets "do-while" (menu run) condition.
            bool IsRunning = true;

            //Starts main loop of this method.

            //"do-while" loop keeps user returning to menu until user chooses to end program (finish order/bestilling) by choosing "9".
            do
            {
                //"do while" calculations: Calculates and sets the calculated variables.

                //Sets "CirkusBilletPrisTotal[X]" according to price and ordered amount per type of Cirkusbillet using "TypeTotalPriceCount" as counter to go through the arrays in sync.                
                for (int TypeTotalPriceCount = 0; TypeTotalPriceCount < 4; TypeTotalPriceCount++)
                {
                    CirkusBilletPrisTotal[TypeTotalPriceCount] = CirkusBilletPris[TypeTotalPriceCount] * CirkusBilletAntal[TypeTotalPriceCount];
                }

                //Sets "SamletPrisTotal" to sum value of "CirkusBilletPrisTotal[X]" by using ".Sum()" to sum all values of array ("CirkusBilletPrisTotal[0]" + "CirkusBilletPrisTotal[1]" + ....+ "CirkusBilletPrisTotal[7]").
                SamletPrisTotal = CirkusBilletPrisTotal.Sum();

                //Menu display part.

                //Clears console and presents menu using the "\n for spacing and the "$" combined with "{}" to call the various Cirkusbillet related variables.
                Console.Clear();
                Console.SetCursorPosition(ScreenCenterX - 20, 5);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Velkommen til Cirkus Svumpukkel!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nHerunder vises vores billet typer. Børn under 0 (?) år kommer gratis ind i følge med en voksen.");                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNyd vores Cirkus");
                Console.ForegroundColor = ConsoleColor.Blue;               
                Console.WriteLine("\nIndtast tallet ud for den billet du ønsker at bestille (efterfulgt af return):");
                Console.ForegroundColor = ConsoleColor.White;

                //Using "for" loop and variable "MenuPrint" to acces arrays and save a few repetitive code lines (but ends up with about the same space-use if space and comments is counted).
                for (int MenuPrint = 0; MenuPrint < 4; MenuPrint++)
                {
                    Console.WriteLine($"\n {MenuPrint + 1}: {CirkusBillet[MenuPrint]}billet til {CirkusBilletPris[MenuPrint]} kr.");
                }

                Console.WriteLine("\nTast 9 efterfulgt af return når du er færdig og parat til at afgive din bestilling. \n");

                //Order progress display part.

                //Displays the current order if final price is not 0 or, in case of 0, that there aren't any order yet ("if-else").                
                if (SamletPrisTotal != 0)
                {
                    Console.WriteLine("Din bestilling er nu:\n");

                    //Uses "TypeOrderCount" as counter to go through array "CirkusBilletAntal" to check if it has value different from 0 and if so display order in counter sync with the 2 other arrays.
                    for (int TypeOrderCount = 0; TypeOrderCount < 4; TypeOrderCount++)
                    {
                        if (CirkusBilletAntal[TypeOrderCount] != 0)
                        {
                            Console.WriteLine($" {CirkusBilletAntal[TypeOrderCount]} {CirkusBillet[TypeOrderCount]}billet(er) af ialt {CirkusBilletPrisTotal[TypeOrderCount]} kr.");
                        }
                    }

                    Console.WriteLine($"\n Total ialt: {SamletPrisTotal} kr.");
                }

                else
                {
                    Console.WriteLine("Du har endnu ikke føjet noget til din bestilling.");
                }

                //Result part: Here the input will create some kind of result.

                /*Sets variable "tast" as user input and runs "switch (tast)" accordingly as in adding to amount of Cirkusbilleter or ending order.
                If input ("Tast") is 1-4 then "TastInputCaseResolver" is called to start resolving current input.
                That in turn calls "IntInputValidCheck" to determine a valid amount of Cirkusbillet chosen before returning that to "TastInputCaseResolver".
                "TastInputCaseResolver" then processes that (updates appropriate arrays) and returns here.*/
                Tast = Console.ReadLine();

                switch (Tast)
                {

                    case "1":

                        TastInputCaseResolver();
                        break;

                    case "2":

                        TastInputCaseResolver();
                        break;

                    case "3":

                        TastInputCaseResolver();
                        break;

                    case "4":

                        TastInputCaseResolver();
                        break;

                    //This "case" differs in that "IsRunning" is set to false and thus breaks the "do-while" loop when "while" checked.
                    case "9":

                        Console.WriteLine("\nDu har trykket på 9 - din bestilling afgives.\n");
                        IsRunning = false;
                        break;

                    default:

                        Console.WriteLine("\nDu har ikke tastet 1, 2, 3, 4 eller 9.\nTryk en tast for at prøve igen:");
                        Console.ReadKey();
                        break;
                }
            } while (IsRunning); //When not true ends main loop of this method.

        }//End method "Opgaverun"


        //Start method "TastInputCaseResolver".
        public static void TastInputCaseResolver()
        {

            /*Converts value of user input "Tast" from "OpgaveRun" to integer.
            Then prepares for-user message ("IIValidCheckCallerPrint") for method "IntInputValidCheck" before calling it.*/
            int IntTast = Convert.ToInt32(Tast);
            IIValidCheckCallerPrint = ($"\nHvor mange {CirkusBillet[IntTast - 1]}billet(er) ønsker du at købe?\n");
            IntInputValidCheck();

            /*"IntInputValidCheck" then returns the validated input "ItemAmountResult" and "TastInputCaseResolver" displays result before using input to update appropriate arrays.
            "Console.ReadKey()" used for user to be able to read message before returning to menu (and thus "Console.Clear()").*/
            Console.WriteLine($"\nDu har føjet {ItemAmountResult} {CirkusBillet[IntTast - 1]}billet(er) til din bestilling\nTryk en tast for at vende tilbage til menuen:");
            CirkusBilletAntal[IntTast - 1] = CirkusBilletAntal[IntTast - 1] + ItemAmountResult;
            Console.ReadKey();

        }//End method "TastInputCaseResolver".


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

                //Clears console and writes desired message from caller ("CallerInputString") and asks user to input users desired number.
                Console.Clear();
                Console.WriteLine(IIValidCheckCallerPrint);
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

                //Runs switch case loop using value "NumberFlag".
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
            } while (InputWrongRunning);//When not true ends do-while (main loop) of this method.

            //Returns result to method caller.
            return ItemAmountResult;

        } //End method "IntInputValidCheck"        
    }
}
