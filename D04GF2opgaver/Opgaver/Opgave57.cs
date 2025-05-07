using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave57
    {
        //Class level setup part: Initializes and/or sets/presets variables.
        
        //Initializes and sets "IIValidCheckCallerPrint" (possibly) used to display message by whatever method calls it.
        public static string IIValidCheckCallerPrint = "";

        //Initializes and sets "ItemAmountResult"- (value returned by "IntInputValidCheck").
        public static int ItemAmountResult = 0;

        //Initializes and sets "KarakterInputAmount" later to be set by user and used to indirectly dertermine List size.
        public static int KarakterInputAmount = 0;

        //Initializes int List created using "KarakterInputAmount".
        public static List<int> KarakterList = new List<int>();

        //Initializes "KarakterListTotal" which is used in method "GradeCalculater".
        static public double KarakterListTotal;

        //Initializes "KarakterAverage" which is the result of method "GradeCalculater".
        public static double KarakterAverage;

        //Initializes and sets "TryAgain" which is used to determine if to run method "OpgaveRun" again.
        public static string TryAgain = "0";

        //Start method "Opgaverun".
        public static void OpgaveRun()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Presets "do-while" (method main loop) condition.
            bool IsRunning = true;

            //Starts main loop of this method.
            do
            {

                //Mainmenu display part.
                Console.Clear();
                Console.WriteLine("Velkommen til et meget gennemsnitligt karakter-beregnings program\n(og ja- det er ligeså spændende som det lyder).");
                Console.WriteLine("Her kan du beregne gennemsnittet af et udvalg af karakterer.\nFørst indtastes hvor mange karakterer der ønskes gennemsnit af, derefter indtastes karaktererne.");
                Console.WriteLine("Tryk en tast for at gå til første indtastnings modul:\n");
                Console.ReadKey();

                //
                do
                { 
                    //Initializes message for use in "IntInputValidCheck"
                    IIValidCheckCallerPrint = ("Hvor mange karakterer ønskes beregnet?");
                
                    //Calls method "IntInputValidCheck".
                    IntInputValidCheck();

                    //Sets "KarakterInputAmount" = "ItemAmountResult" (Returnvalue from "IntInputValidCheck").
                    KarakterInputAmount = ItemAmountResult;

                    //If a useless nuumber like 0 has been input.
                    if (KarakterInputAmount <= 0)
                    {
                        Console.WriteLine("\nDu har indtastet et ubrugeligt antal.\nTallet skal være mindst et men det giver først menning ved mindst to.");
                        Console.WriteLine("\nTryk en tast for at prøve igen.");
                        Console.ReadKey();
                    }
                    else
                    {
                        //Displays the selected amount of grades to enter.                
                        Console.WriteLine($"\nØnsket antal karakterer til indtastning: {KarakterInputAmount}\nTryk en tast for at fortsætte.");
                        Console.ReadKey();
                    }
                }
                while (KarakterInputAmount <= 0);

                //Calls "KarakterListFiller" that fills "KarakterList" with data.
                KarakterListFiller();

                //Calls "GradeCalculater" that calculates average of grades.
                GradeCalculater();

                //Clears console. Following code until "while" writes the input grades and the result of calculation as well as asks user if user wants to try again. 
                Console.Clear();
                Console.WriteLine("De indtastede karakterer var:\n");

                //Goes through each ("foreach") integer index value in "KarakterList" and does the code in curlies.
                foreach (int value in KarakterList)
                {
                    //Writing the input grades according to value in current index ("KarakterList") plus some "easier to view the numbers" spaces.
                    //Also rectifies numbers in case of 00 or 03 grades.
                    if (value == 0)
                    {
                        Console.Write("  0" + value + "  ");
                    }
                    else if (value == 2)
                    {
                        Console.Write("  0" + value + "  ");
                    }
                    else
                        Console.Write("  " + value + "  ");
                }

                //Calls and writes value of "karakterAverage" (result of "gradecalculator") using "$" and "{}". Rounds of result with ":N2" (two decimals).
                Console.WriteLine($"\n\nGennemsnittet er: {KarakterAverage:N2}\n");
                //Tells user to input whether or not user wants to calculate again and then reads and processes the input.
                Console.WriteLine("\nTryk b (+ enter) for at beregne igen ellers tryk en anden tast efterfulgt af enter for at afslutte!\n");
                TryAgain = Console.ReadLine();

                // Informs user that user have selected to calculate again and clears data from "KarakterList" (not to have spill-over data).
                if (TryAgain == "b")
                {
                    Console.WriteLine("\nDu har valgt at prøve igen.\nTryk en tast for at fortsætte.");
                    KarakterList.Clear();
                }

                //Sets "IsRunning" to false to end loop.
                else
                {
                    IsRunning = false;
                    Console.WriteLine("\nDu har valgt at afslutte.\nDet var da ærgeligt- nu var vi lige så gennemsnitlige.");                    
                }

            } while (IsRunning); //When not true ends main loop of this method.

        }//End method "Opgaverun".

        //**NEW METHOD**

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

            //Resets "IIValidCheckCallerPrint" so it's ready for possible new use.
            IIValidCheckCallerPrint = "";

            //Returns result to method caller.
            return ItemAmountResult;

        } //End method "IntInputValidCheck"
        
        //**NEW METHOD**

        //Start method "KarakterListFiller()".
        public static void KarakterListFiller()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Presets "do-while" (input "ItemAmount" check run) condition.
            bool ListFillingRunning = true;

            //Initializes integer version of user input "KarakterInput".
            int KarakterInputInt;

            //Starts main loop of this method.
            do
            {
                //Runs "for" loop until array is filled with data according to "KarakterInputCounter" vs "KarakterInputAmount" (user defined input amount).
                for (int KarakterInputCounter = 0; KarakterInputCounter <= KarakterInputAmount - 1; KarakterInputCounter++)
                {
                    //Clears cosole and instructs user, 
                    Console.Clear();
                    Console.WriteLine("Velkommmen til andet indtastnings modul. Her kan du indtaste karaktererne.");
                    Console.WriteLine("Brug værdierne fra den nye karakter skala (-3, 00, 02, 4, 7, 10 & 12)\n");
                    Console.WriteLine($"Indtast karakter nr. {KarakterInputCounter + 1}:");

                    //Stops "for-while" by setting "ListFillingRunning" to false once last karakter has had its input.
                    if (KarakterInputCounter == KarakterInputAmount - 1);
                    {                       
                        ListFillingRunning = false;
                    }

                    string KarakterInput = Console.ReadLine();
                                        
                    //Runs "switch case" according to user input "KarakterInput, filling list "KarakterList" with data or telling user to try again in case of wrong input.
                    switch (KarakterInput)
                    {
                        case "-3":
                            
                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add(KarakterInputInt);
                            break;

                        case "00":
                                                        
                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add(KarakterInputInt);
                            break;

                        case "02":

                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add(KarakterInputInt);
                            break;

                        case "4":

                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add (KarakterInputInt);
                            break;

                        case "7":

                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add(KarakterInputInt);
                            break;

                        case "10":

                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add(KarakterInputInt);
                            break;

                        case "12":

                            KarakterInputInt = Convert.ToInt32(KarakterInput);
                            KarakterList.Add(KarakterInputInt);
                            break;

                        default:

                            Console.WriteLine("Du har indtastet en ukorrekt karakter.\n Husk at du skal skrive dem som de er.");
                            Console.WriteLine("Det vil sige at f.eks 00 skal skives med to nuller og ikke et.");
                            Console.WriteLine("Tryk en tast for at prøve igen.");
                            //Adjusts counter "KarakterInputCounter" -1 as no value was entered and switch case needs to be run with correct "KarakterInputCounter" until inpur is correct. 
                            KarakterInputCounter--;
                            //Makes sure "do-while" doesn't stop if on last input by resetting "ListFillingRunning" = true and thus passing "while" check.
                            ListFillingRunning = true;
                            break;

                    }
                                        
                }

            } while (ListFillingRunning);//When not true ends do-while (main loop) of this method.

        }//End method "KarakterListFiller()".

        //**NEW METHOD**

        //Start method "GradeCalculater".

        //Sets "KarakterListTotal" as sum of "KarakterList" (all the grades input). Then calculates  
        public static void GradeCalculater()
        {
            KarakterListTotal = KarakterList.Sum();
            KarakterAverage = (KarakterListTotal / KarakterInputAmount);
        }//End method "GradeCalculater".
    }
}