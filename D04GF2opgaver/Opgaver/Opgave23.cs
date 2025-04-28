using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave23
    {
        public static void OpgaveRun()
        {
            //Initializes variables and pre-sets them.
            string sizeask = "0";
            string antalstring = "0";
            int price = 0;
            int small = 120;
            int medium = 160;
            int large = 185;
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
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. This is the introduction to the store.
                Console.WriteLine("Velkommen til T-shirt butikken. Her kan du købe T-shirts i forskellige størrelser.");
                Console.WriteLine();
                Console.WriteLine("Vi fører i øjeblikket T-shirts i tre størrelser:");
                Console.WriteLine();
                Console.WriteLine("Small til 120 kr.");
                Console.WriteLine();
                Console.WriteLine("Medium til 160 kr.");
                Console.WriteLine();
                Console.WriteLine("Large til 185 kr.");
                Console.WriteLine();
                Console.WriteLine("Hvis du køber mere end 10 T-shirts får du 5% rabat.");
                Console.WriteLine();
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position. Asks user for desired size.
                Console.WriteLine("Indtast din ønskede størrelse (brug venligst s for small, m for medium og l for large) og afslut med tryk på enter eller return: ");
                //Reads ("ReadLine") and sets variable "sizeask" according to user input (input is converted to lower case if necessary by "ToLower").
                sizeask = Console.ReadLine().ToLower();
                //Checks if input is "s" for small and if yes sets "price". If not moves on to "else if".
                if (sizeask == "s")
                {
                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                    Console.WriteLine("Du har valgt størrelse Small");
                    price = small;
                    //Input accepted so stop "while (true)" loop.
                    break;
                }
                //Checks if input is "m" for medium and if yes sets "price". If not moves on to "else if".
                else if (sizeask == "m")
                {
                    //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position.
                    Console.WriteLine("Du har valgt størrelse Medium");
                    price = medium;
                    //Input accepted so stop "while (true)" loop.
                    break;
                }
                //Checks if input is "l" for large and if yes sets "price". If not moves on to "else".
                else if (sizeask == "l")
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
            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position - uses "$...{}..." to display value of applicable variables. Sums up purchase order.
            Console.WriteLine($"Du har bestilt {antalint} T-shirt(s) i størrelse {sizeask} af {price} kr. stykket.");
            //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position - uses "$...{}..." to display value of applicable variables. Displays total price without any applicable discount.
            Console.WriteLine($"Det giver en samlet pris på {bulkprice} kr.");
            //Checks if discount applies and if so runs code in curly brackets.
            if (discount < 1)
            {
                //Calculates discount and sets it as value for "rabatspar".
                rabatspar = (1 - discount) * bulkprice;
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position - uses "$...{}..." to display value of applicable variables - the "{...:N2}" cuts number to 2 decimals. Explains user that a discount applies due to amount bought.
                Console.WriteLine($"Men da du har købt mere end 10 T-shirts får du fem procents rabat og derfor er din endelige pris {finalprice:N2} kr.");
                Console.WriteLine($"Du har altså sparet {rabatspar:N2} kr.");
                Console.WriteLine("Tryk en tast for at afslutte.");
            }
            //If discount does not apply runs following code in curly brackets.
            else
            {
                //Writes "TEXT" ("WriteLine" uses full line) in terminal at current cursor position - uses "$...{}..." to display value of applicable variables. Explains user that a discount does not apply due to amount bought.
                Console.WriteLine($"Da du ikke har købt mere end 10 T-shirts får du desværre ikke rabat og derfor er de {finalprice:N2} kr. også din endelige pris.");
                Console.WriteLine("Tryk en tast for at afslutte.");
            }

        }
    }
}   
