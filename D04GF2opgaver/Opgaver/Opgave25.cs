using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave25
    {
        public static string RoomAsk = "0";
        public static string antalRoomstring = "0";
        public static string antalDaysstring = "0";
        public static string RoomType = "0";
        public static int price = 0;
        public static int Enkelt = 765;
        public static int Dobbelt = 980;
        public static int large = 1250;
        public static int antalDaysint = 0;
        public static int antalRoomint = 0;
        public static int numberflag = 1;
        public static int numberflag2 = 1;
        public static int bulkprice = 0;
        public static int TotalPrice;
        public static double EURObulkprice = 0;
        public static double EUROTotalPrice;
        public static bool IsRunning = true;
        public static bool IsRunning2 = true;
        public static bool IsRunning3 = true;
        public static bool MainMenuRunning = true;
        public static string MainMenuSelection = "0";
        public static void OpgaveRun()
        {
            //Initializes variables and pre-sets them.                  

            //Starts main menu.
            while (MainMenuRunning)
            {
                MainMenuSelection = "0";
                //Clears terminal screen.
                Console.Clear();
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. This is the introduction to the (mostly used as 1 hour) hotel.
                Console.WriteLine("Velkommen til Det Lumre Hotel.\nHer kan du prøve at gætte hvad gæsterne før dig har lavet i sengen.\nTIP: Hvis du ikke betaler gebyret for skift af sengetøj er det nemmere at gætte.");
                Console.WriteLine("\nVi har tre typer værelser:\nEnkelt, Dobbelt og Familie (hvis du synes det er ok at tage børn med til et sted som dette).");
                Console.WriteLine("\nHvis du ønsker at betale med EURO er hotellets vekselkurs 100 EURO / 725 dkk");
                if (TotalPrice != 0)
                {
                    Console.WriteLine($"Din bestilling indtil nu er: {TotalPrice} kr. eller {EUROTotalPrice:N2} EURO.");
                }
                Console.WriteLine("Hvis du har færdiggjort din bestilling så tryk f (og enter).\nEllers tryk en anden tast og enter for at forsætte til bestilling.");
                MainMenuSelection = Console.ReadLine().ToLower();

                if (MainMenuSelection != "f")
                {
                    RoomAsk = "0";
                    antalRoomstring = "0";
                    antalDaysstring = "0";
                    RoomType = "0";
                    price = 0;
                    Enkelt = 765;
                    Dobbelt = 980;
                    large = 1250;
                    antalDaysint = 0;
                    antalRoomint = 0;
                    numberflag = 1;
                    numberflag2 = 1;
                    bulkprice = 0;
                    EURObulkprice = 0;
                    IsRunning = true;
                    IsRunning2 = true;
                    IsRunning3 = true;

                    //"while (IsRunning)" loop repeats until user input is valid and moves on ("IsRunning = false") when valid.
                    while (IsRunning)
                    {                                             
                        //Clears terminal screen.
                        Console.Clear();
                        Console.WriteLine("\nEnkeltværelse koster 765 kr. pr. dag.");
                        Console.WriteLine("\nDobbeltværelse koster 980 kr. pr. dag.");
                        Console.WriteLine("\nFamilieværelse (igen- børn her- really?) koster 1250 kr. pr. dag.");
                        //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Asks user for desired size.
                        Console.WriteLine("\nIndtast ønsket type af værelse (brug venligst E for Enkelt, D for Dobbelt og F for Familie)\nog afslut med tryk på enter eller return:\n");

                        //Reads ("ReadLine") and sets variable "RoomAsk" according to user input (input is converted to Upper case if necessary by "ToUpper").
                        RoomAsk = Console.ReadLine().ToUpper();

                        //Checks if input is "E" for Enkelt and if yes sets "price". If not moves on to "else if".
                        if (RoomAsk == "E")
                        {
                            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                            Console.WriteLine("Du har valgt Enkeltværelse.");
                            price = Enkelt;
                            //Input accepted so stop "while (true)" loop.
                            IsRunning = false;
                        }
                        //Checks if input is "D" for Dobbelt and if yes sets "price". If not moves on to "else if".
                        else if (RoomAsk == "D")
                        {
                            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                            Console.WriteLine("Du har valgt Dobbeltvørelse.");
                            price = Dobbelt;
                            //Input accepted so stop "while (true)" loop.
                            IsRunning = false;
                        }
                        //Checks if input is "F" for large and if yes sets "price". If not moves on to "else".
                        else if (RoomAsk == "F")
                        {
                            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                            Console.WriteLine("Du har valgt Familieværelse");
                            price = large;
                            //Input accepted so stop "while (true)" loop.
                            IsRunning = false;
                        }
                        //Since input is not "E", "D" or "F" user has likely made an invalid input and will be asked to try again.
                        else
                        {
                            //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart size selection loop.
                            Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst kun E, D eller F og afslut med tryk på enter eller return.");
                            Console.WriteLine("Tryk en tast for at prøve igen!");
                            Console.ReadKey();
                        }
                    }//"while (IsRunning)" loop repeats until user input is valid and moves on ("IsRunning = false").


                    //Following code block uses "while" loop and "try - catch" to check if user input is a valid number and then set amount of rooms.
                    while (IsRunning2)
                    {
                        //Resets "numberflag"
                        numberflag = 1;
                        //Clears terminal screen.
                        Console.Clear();
                        //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Asks user for number of T-shirts.
                        Console.WriteLine("Du har nu valgt værelsestype. Nu skal du vælge antal.");
                        Console.WriteLine("Indtast antal og brug venligst kun tal (cifre - ikke bogstaver eller andre tegn):");
                        //Sets variable "antalDaysstring" according to user keyboard input.
                        antalRoomstring = Console.ReadLine();
                        //Demands each ("foreach") character in string "antalDaysstring" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                        foreach (char mule in antalRoomstring)
                        {
                            //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are written in single quotes) and thus not a number (numbers in character is from 0 to 9).
                            if (mule < '0' || mule > '9')
                            {
                                //If a character in "antalDaysstring" is not a number then do the following: set variable "numberflag" to 0 and stop check ("IsRunning = false" linked to "foreach") as no further checking is necessary.
                                numberflag = 0;
                            }
                        }
                        //If "numberflag" was not set to 0 (not altered as in only number(s) present in user input ("antalDaysstring") then do the following "IsRunning = false" (stops "while (true)" loop).
                        if (numberflag != 0)
                        {
                            //Sets variable "antalRoomint" to integer version of "antalRoomstring".
                            antalRoomint = Convert.ToInt32(antalRoomstring);
                            IsRunning2 = false;
                        }
                        //If "numberflag" was set to 0 (altered as in not only number(s) present in user input ("antalDaysstring") then do the following in "else{}" (basically re-runs "while (true)" loop).
                        else
                        {
                            //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                            Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                            Console.WriteLine("Tryk en tast for at prøve igen!");
                            Console.ReadKey();
                        }
                    }//"while (true)" loop repeats until user input is valid and moves on ("IsRunning2 = false").


                    //Following code block uses "while" loop and "try - catch" to check if user input is a valid number and then set amount of days.
                    while (IsRunning3)
                    {
                        //Resets "numberflag"
                        numberflag2 = 1;
                        //Clears terminal screen.
                        Console.Clear();
                        //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Asks user for number of T-shirts.
                        Console.WriteLine("Du har nu valgt antal værelser. Nu skal du vælge antal dage.");
                        Console.WriteLine("Indtast antal og brug venligst kun tal (cifre - ikke bogstaver eller andre tegn):");
                        //Sets variable "antalDaysstring" according to user keyboard input.
                        antalDaysstring = Console.ReadLine();
                        //Demands each ("foreach") character in string "antalDaysstring" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                        foreach (char mule in antalDaysstring)
                        {
                            //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are written in single quotes) and thus not a number (numbers in character is from 0 to 9).
                            if (mule < '0' || mule > '9')
                            {
                                //If a character in "antalDaysstring" is not a number then do the following: set variable "numberflag" to 0 and stop check ("IsRunning = false" linked to "foreach") as no further checking is necessary.
                                numberflag2 = 0;
                            }
                        }
                        //If "numberflag" was not set to 0 (not altered as in only number(s) present in user input ("antalDaysstring") then do the following "IsRunning = false" (stops "while (true)" loop).
                        if (numberflag2 != 0)
                        {
                            //Sets variable "antalDaysint" to integer version of "antalDaysstring".            
                            antalDaysint = Convert.ToInt32(antalDaysstring);
                            IsRunning3 = false;
                        }
                        //If "numberflag" was set to 0 (altered as in not only number(s) present in user input ("antalDaysstring") then do the following in "else{}" (basically re-runs "while (true)" loop).
                        else
                        {
                            //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                            Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                            Console.WriteLine("Tryk en tast for at prøve igen!");
                            Console.ReadKey();
                        }
                    }//"while (true)" loop repeats until user input is valid and moves on ("IsRunning3 = false").


                    //Calculates price.
                    bulkprice = antalDaysint * antalRoomint * price;
                    EURObulkprice = bulkprice / 7.25;

                    //Sets coorect room type according to user selection.
                    if (RoomAsk == "E")
                    {
                        RoomType = "enkeltværelse";
                    }
                    else if (RoomAsk == "D")
                    {
                        RoomType = "dobbeltværelse";
                    }
                    else if (RoomAsk == "F")
                    {
                        RoomType = "familieværelse";
                    }

                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Sums up purchase order.
                    Console.WriteLine($"Du har bestilt {antalRoomint} {RoomType} i {antalDaysint} dage af {price} kr. stykket.");
                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Displays total price without any applicable discount.
                    Console.WriteLine($"Det giver en pris på {bulkprice} kr. eller {EURObulkprice:N2} EURO.");
                    Console.WriteLine("Tryk en tast for at afslutte denne del af reservationen.");
                    Console.ReadKey();
                    TotalPrice = TotalPrice + bulkprice;
                    EUROTotalPrice = EUROTotalPrice + EURObulkprice;
                }

                else
                {
                    Console.WriteLine("Bestilling afsluttes. Tryk en tast");
                    Console.ReadKey ();
                    MainMenuRunning = false;
                }
            }//"while (MainMenuRunning)" loop repeats until user input asks to finish ("IsRunning = false").
        }
    }
}
