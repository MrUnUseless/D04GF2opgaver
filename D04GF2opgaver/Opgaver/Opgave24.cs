using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave24
    {
        public static void OpgaveRun()
        {
            //Initializes variables and pre-sets them.
            string RoomAsk = "0";
            string antalstring = "0";
            int price = 0;
            int Enkelt = 765;
            int Dobbelt = 980;
            int large = 1250;
            int antalint = 0;
            int numberflag = 1;
            int bulkprice = 0;
            double discount = 1;
            double finalprice = 0;
            double rabatspar = 0;
            //"while (true)" loop repeats until user input is valid and moves on ("break") when valid.
            while (true)
            {
                //Clears terminal screen.
                Console.Clear();
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. This is the introduction to the (mostly used as 1 hour) hotel.
                Console.WriteLine("Velkommen til Det Lumre Hotel.\nHer kan du prøve at gætte hvad gæsterne før dig har lavet i sengen.\nTIP: Hvis du ikke betaler gebyret for skift af sengetøj er det nemmere at gætte.");                
                Console.WriteLine("\nVi har tre typer værelser:\nEnkelt, Dobbelt og Familie (hvis du synes det er ok at tage børn med til et sted som dette).");                
                Console.WriteLine("\nEnkeltværelse koster 765 kr. pr. dag.");             
                Console.WriteLine("\nDobbeltværelse koster 980 kr. pr. dag.");                
                Console.WriteLine("\nFamilieværelse (igen- børn her- really?) koster 1250 kr. pr. dag.");                
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Asks user for desired size.
                Console.WriteLine("\nIndtast ønsket type af værelse (brug venligst E for Enkelt, D for Dobbelt og F for Familie)\nog afslut med tryk på enter eller return:\n");
                //Reads ("ReadLine") and sets variable "RoomAsk" according to user input (input is converted to lower case if necessary by "ToLower").
                RoomAsk = Console.ReadLine().ToUpper();
                //Checks if input is "E" for Enkelt and if yes sets "price". If not moves on to "else if".
                if (RoomAsk == "E")
                {
                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                    Console.WriteLine("Du har valgt Enkeltværelse");
                    price = Enkelt;
                    //Input accepted so stop "while (true)" loop.
                    break;
                }
                //Checks if input is "D" for Dobbelt and if yes sets "price". If not moves on to "else if".
                else if (RoomAsk == "m")
                {
                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                    Console.WriteLine("Du har valgt størrelse Medium");
                    price = Dobbelt;
                    //Input accepted so stop "while (true)" loop.
                    break;
                }
                //Checks if input is "l" for large and if yes sets "price". If not moves on to "else".
                else if (RoomAsk == "l")
                {
                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                    Console.WriteLine("Du har valgt størrelse large");
                    price = large;
                    //Input accepted so stop "while (true)" loop.
                    break;
                }
                //Since input is not "s", "m" or "l" user has likely made an invalid input and will be asked to try again.
                else
                {
                    //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart size selection loop.
                    Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst kun s, m eller l og afslut med tryk på enter eller return.");
                    Console.WriteLine("Tryk en tast for at prøve igen!");
                    Console.ReadKey();
                }
            }
            //"while (true)" loop repeats until user input is valid and moves on ("break") when valid.
            while (true)
            {
                //Resets "numberflag"
                numberflag = 1;
                //Clears terminal screen.
                Console.Clear();
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Asks user for number of T-shirts.
                Console.WriteLine("Du har nu valgt størrelse. Nu skal du vælge antal - husk at du får rabat hvis du køber mere end 10 stk.");
                Console.WriteLine("Indtast antal og brug venligst kun tal (cifre - ikke bogstaver eller andre tegn):");
                //Sets variable "antalstring" according to user keyboard input.
                antalstring = Console.ReadLine();
                //Demands each ("foreach") character in string "antalstring" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                foreach (char mule in antalstring)
                {
                    //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are written in single quotes) and thus not a number (numbers in character is from 0 to 9).
                    if (mule < '0' || mule > '9')
                    {
                        //If a character in "antalstring" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break" linked to "foreach") as no further checking is necessary.
                        numberflag = 0;
                        break;
                    }
                }
                //If "numberflag" was not set to 0 (not altered as in only number(s) present in user input ("antalstring") then do the following "break" (stops "while (true)" loop).
                if (numberflag != 0)
                {
                    break;
                }
                //If "numberflag" was set to 0 (altered as in not only number(s) present in user input ("antalstring") then do the following in "else{}" (basically re-runs "while (true)" loop).
                else
                {
                    //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                    Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                    Console.WriteLine("Tryk en tast for at prøve igen!");
                    Console.ReadKey();
                }
            }
            //Sets variable "antalint" to integer version of "antalstring".            
            antalint = Convert.ToInt32(antalstring);
            //Calculates price before discount.
            bulkprice = antalint * price;
            //Checks for discount (if customer bought more than 10) and sets multiplier to 0.95 if applicable.
            if (antalint > 10)
            {
                discount = 0.95;
            }
            //Calculates price after possible discount.
            finalprice = discount * bulkprice;
            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Sums up purchase order.
            Console.WriteLine($"Du har bestilt {antalint} T-shirt(s) i størrelse {RoomAsk} af {price} kr. stykket.");
            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Displays total price without any applicable discount.
            Console.WriteLine($"Det giver en samlet pris på {bulkprice} kr.");
            //Checks if discount applies and if so runs code in curly brackets.
            if (discount < 1)
            {
                //Calculates discount and sets it as value for rabatspar.
                rabatspar = (1 - discount) * bulkprice;
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Explains user that a discount applies due to amount bought.
                Console.WriteLine($"Men da du har købt mere end 10 T-shirts får du fem procents rabat og derfor er din endelige pris {finalprice:N2} kr.");
                Console.WriteLine($"Du har altså sparet {rabatspar:N2} kr.");
                Console.WriteLine("Tryk en tast for at afslutte.");
            }
            //If discount does not apply runs following code in curly brackets.
            else
            {
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                Console.WriteLine($"Da du ikke har købt mere end 10 T-shirts får du desværre ikke rabat og derfor er de {finalprice:N2} kr. også din endelige pris.");
                Console.WriteLine("Tryk en tast for at afslutte.");
            }

        }
    }
}
