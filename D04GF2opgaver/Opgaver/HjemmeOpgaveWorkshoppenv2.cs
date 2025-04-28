using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class HjemmeOpgaveWorkshoppenv2
    {
        public static void OpgaveRun()
        {



            //Clears terminal screen.
            Console.Clear();

                      
            //Initializes variables and pre-sets some.
            string hmvalg = "0";
            string gmvalg = "0";
            string tmvalg = "0";
            string terminate;

            
            //Calls main Menu
            HjemmeOpgaveWorkshoppenv2.HovedMenu();



        }
        //Method hovedMenu.
        public static void HovedMenu()
        {

            //Initializes and sets variable.
            string hmvalg = "0";

            //Uses "do while" to check input from main menu.
            do
            {
                //Clears terminal screen.
                Console.Clear();

                //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line and "\n" also changes to new line.
                Console.WriteLine("Velkommen til Workshoppen");
                Console.WriteLine("\nDu kan nu vælge mellem følgende:");
                Console.WriteLine("\nBeregning af omkreds og areal af visse geometriske figurer (tryk o efterfulgt af enter)");
                Console.WriteLine("\nAt få vist visse tal tabeller (tryk t efterfulgt af enter)");
                Console.WriteLine("\nAfslutning af program (tryk a efterfulgt enter)");
                //
                hmvalg = Console.ReadLine().ToLower();

                //
                if (hmvalg == "o")
                {
                    HjemmeOpgaveWorkshoppenv2.GeometriMenu();
                }

                //
                else if (hmvalg == "t")
                {
                    HjemmeOpgaveWorkshoppenv2.TabelMenu();
                }

                //
                else if (hmvalg == "a")
                {
                    HjemmeOpgaveWorkshoppenv2.AfslutMenu();
                }

                // (hmvalg != "o" && hmvalg != "t" && hmvalg != "a")
                else
                {
                    Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst kun o, t eller a og afslut med tryk på enter eller return.");
                    Console.WriteLine("Tryk en tast for at prøve igen!");
                    Console.ReadKey();
                }

            } while (hmvalg != "o" && hmvalg != "t" && hmvalg != "a");

        }

        //Method GeometriMenu.
        public static void GeometriMenu()
        {

            //Initializes and sets variable.
            string gmvalg = "0";

            //
            do
            {
                //

                //Clears terminal screen.
                Console.Clear();
                //
                Console.WriteLine("Velkommen til beregning af omkreds og areal af visse geometriske figurer");
                Console.WriteLine("\nDu kan vælge mellem følgende:");
                Console.WriteLine("\nBeregning af trekant (tryk t)");
                Console.WriteLine("\nBeregning af firkant (tryk f)");
                Console.WriteLine("\nBeregning af cirkel (tryk c)");                
                Console.WriteLine("\nAfslutning af program (tryk a)");
                gmvalg = Console.ReadLine().ToLower();

                //
                if (gmvalg == "t")
                {
                    HjemmeOpgaveWorkshoppenv2.TrekantsBeregning();
                }

                //
                else if (gmvalg == "f")
                {
                    HjemmeOpgaveWorkshoppenv2.FirkantsBeregning();
                }

                //
                else if (gmvalg == "c")
                {
                    HjemmeOpgaveWorkshoppenv2.CirkelBeregning();
                }
                                
                //
                else if (gmvalg == "a")
                {
                    HjemmeOpgaveWorkshoppenv2.AfslutMenu();
                }

                //
                else
                {
                    Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst kun t, f, c eller a og afslut med tryk på enter eller return.");
                    Console.WriteLine("Tryk en tast for at prøve igen!");
                    Console.ReadKey();
                }


            } while (gmvalg != "t" && gmvalg != "f" && gmvalg != "c" && gmvalg != "a");
        }

        //Method TrekantsBeregning.
        public static void TrekantsBeregning()
        {

            //
            do
            {
                //Clears terminal screen.
                Console.Clear();

                //Initializes variables.
                string bredde;
                string højde;
                double omkreds;
                double hypotenuse1;
                double hypotenuse2;
                double bredde1;
                double højde1;
                double areal;
                
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
                Console.WriteLine("I dette program kan du beregne omkredsen og arealet på en retvinklet trekant hvis du kender højde og bredde.");

                //"while (true)" loops through chekking if input is valid (cipher(s)).
                while (true)
                {
                    //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.                        
                    Console.WriteLine("\nIndtast tal for bredden:");
                    bredde = Console.ReadLine();

                    //Clears terminal screen.
                    Console.Clear();

                    // Initializes and sets "nummberFlag".
                    int numberflag = 1;

                    //Demands each ("foreach") character in string "bredde" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                    foreach (char c in bredde)
                    {
                        //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number (numbers in character is from 0 to 9).
                        if (c < '0' || c > '9')
                        {
                            //If a character in "bredde" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break") as no further checking is necessary.
                            numberflag = 0;
                            break;
                        }
                    }

                    //If all character(s) in "bredde" is a cipher (variable "numberflag" not set to 0) and user input was more than zero key strokes ("bredde.Length > 0") then do the following:
                    if (numberflag == 1 && bredde.Length > 0)
                    {
                        // Exit ("break") loop ("while (true)") as we have a valid value for "bredde".
                        break;
                    }
                    else
                    {
                        //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();

                    }
                }

                //
                //"while (true)" loops through chekking if input is valid (cipher(s)).
                while (true)
                {
                    //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.                        
                    Console.WriteLine("\nIndtast tal for højden:");
                    højde = Console.ReadLine();

                    //Clears terminal screen.
                    Console.Clear();

                    // Initializes and sets "nummberFlag".
                    int numberflag = 1;

                    //Demands each ("foreach") character in string "højde" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                    foreach (char c in højde)
                    {
                        //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number (numbers in character is from 0 to 9).
                        if (c < '0' || c > '9')
                        {
                            //If a character in "højde" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break") as no further checking is necessary.
                            numberflag = 0;
                            break;
                        }
                    }

                    //If all character(s) in "højde" is a cipher (variable "numberflag" not set to 0) and user input was more than zero key strokes ("højde.Length > 0") then do the following:
                    if (numberflag == 1 && højde.Length > 0)
                    {
                        // Exit ("break") loop ("while (true)") as we have a valid value for "højde".
                        break;
                    }
                    else
                    {
                        //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();

                    }
                }

                //Sets variable "bredde1" to "double" version of "string" "bredde".
                bredde1 = Convert.ToDouble(bredde);

                //Sets variable "højde1" to "double" version of "string" "højde".
                højde1 = Convert.ToDouble(højde);

                //Calculates the length² of the hypotenuse (the "c" side) of the triangle and sets it as value for "hypotenuse1" - basically using the Pythagoras' Theorem of a² + b² = c² ("hypotenuse1" being the c²).
                hypotenuse1 = Math.Pow(højde1, 2) + Math.Pow(bredde1, 2);
                //Calculates the length of the hypotenuse by square rooting of "hypotenuse1" and sets it as value for "hypotenuse2".            
                hypotenuse2 = Math.Sqrt(hypotenuse1);
                //Calculates the perimeter of the tritangle and sets it as value for "omkreds".
                omkreds = hypotenuse2 + højde1 + bredde1;
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "omkreds"" is the result of the previous calculation and is called by "$" and "{}".
                Console.WriteLine($"Omkredsen af den retvinklede trekant er {omkreds}");

                //Calculates the surface of the triangle and sets it as value for "areal".
                areal = 0.5 * højde1 * bredde1;
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable areal is the result of the calculation and is called by "$" and {}
                Console.WriteLine($"\nArealet af trekanten er {areal}");

                //Waits for user input:
                Console.WriteLine("Tryk en tast:");
                Console.ReadKey();
                return;

            } while (true);
        }

        //Method FirkantsBeregning.
        public static void FirkantsBeregning()
        {

            //
            do
            {
                //Clears terminal screen.
                Console.Clear();

                //Initializes variables.
                string bredde;
                string højde;
                double omkreds;
                double bredde1;
                double højde1;
                double areal;


                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
                Console.WriteLine("I dette program kan du beregne omkredsen og arealet på en firkant hvis du kender højde og bredde.");

                //"while (true)" loops through chekking if input is valid (cipher(s)).
                while (true)
                {
                    //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.                        
                    Console.WriteLine("\nIndtast tal for bredden:");
                    bredde = Console.ReadLine();

                    //Clears terminal screen.
                    Console.Clear();

                    // Initializes and sets "nummberFlag".
                    int numberflag = 1;

                    //Demands each ("foreach") character in string "bredde" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                    foreach (char c in bredde)
                    {
                        //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number (numbers in character is from 0 to 9).
                        if (c < '0' || c > '9')
                        {
                            //If a character in "bredde" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break") as no further checking is necessary.
                            numberflag = 0;
                            break;
                        }
                    }

                    //If all character(s) in "bredde" is a cipher (variable "numberflag" not set to 0) and user input was more than zero key strokes ("bredde.Length > 0") then do the following:
                    if (numberflag == 1 && bredde.Length > 0)
                    {
                        // Exit ("break") loop ("while (true)") as we have a valid value for "bredde".
                        break;
                    }
                    else
                    {
                        //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();

                    }

                }


                //"while (true)" loops through chekking if input is valid (cipher(s)).
                while (true)
                {
                    //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.                        
                    Console.WriteLine("\nIndtast tal for højden:");
                    højde = Console.ReadLine();

                    //Clears terminal screen.
                    Console.Clear();

                    // Initializes and sets "nummberFlag".
                    int numberflag = 1;

                    //Demands each ("foreach") character in string "højde" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                    foreach (char c in højde)
                    {
                        //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number (numbers in character is from 0 to 9).
                        if (c < '0' || c > '9')
                        {
                            //If a character in "højde" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break") as no further checking is necessary.
                            numberflag = 0;
                            break;
                        }
                    }

                    //If all character(s) in "højde" is a cipher (variable "numberflag" not set to 0) and user input was more than zero key strokes ("højde.Length > 0") then do the following:
                    if (numberflag == 1 && højde.Length > 0)
                    {
                        // Exit ("break") loop ("while (true)") as we have a valid value for "højde".
                        break;
                    }
                    else
                    {
                        //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();

                    }
                }


                //Sets variable "bredde1" to "double" version of "string" "bredde".
                bredde1 = Convert.ToDouble(bredde);

                //Sets variable "højde1" to "double" version of "string" "højde".
                højde1 = Convert.ToDouble(højde);

                //Calculates the perimeter of the tritangle and sets it as value for "omkreds".
                omkreds = 2 * (højde1 + bredde1);
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "omkreds"" is the result of the previous calculation and is called by "$" and "{}".
                Console.WriteLine($"Omkredsen af den retvinklede trekant er {omkreds}");

                //Calculates the surface of the triangle and sets it as value for "areal".
                areal = højde1 * bredde1;
                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable areal is the result of the calculation and is called by "$" and {}
                Console.WriteLine($"\nArealet af firkanten er {areal}.");

                //Waits for user input:
                Console.WriteLine("Tryk en tast:");
                Console.ReadKey();
                break;

            } while (true);
        }

        //
        //Method CirkelBeregning.
        public static void CirkelBeregning()
        {

            //
            do
            {
                //Clears terminal screen.
                Console.Clear();

                //Initializes variables.
                string radius;
                double areal;
                double omkreds;
                double radius1;


                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.
                Console.WriteLine("I dette program kan du beregne arealet og omkredsen på en cirkel ved hjælp af radius.");

                //"while (true)" loops through chekking if input is valid (cipher(s)).
                while (true)
                {
                    //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line.                        
                    Console.WriteLine("\nIndtast tal for radius:");
                    radius = Console.ReadLine();

                    //Clears terminal screen.
                    Console.Clear();

                    // Initializes and sets "nummberFlag".
                    int numberflag = 1;

                    //Demands each ("foreach") character in string "radius" to be gone through (one by one) and set as operating value for variable "mule" which in turn is initialized as type "char" (character).
                    foreach (char c in radius)
                    {
                        //Here "mule" is checked to see if it's smaller than zero or bigger than nine (characters are writen in single quotes) and thus not a number (numbers in character is from 0 to 9).
                        if (c < '0' || c > '9')
                        {
                            //If a character in "radius" is not a number then do the following: set variable "numberflag" to 0 and stop check ("break") as no further checking is necessary.
                            numberflag = 0;
                            break;
                        }
                    }

                    //If all character(s) in "radius" is a cipher (variable "numberflag" not set to 0) and user input was more than zero key strokes ("radius.Length > 0") then do the following:
                    if (numberflag == 1 && radius.Length > 0)
                    {
                        // Exit ("break") loop ("while (true)") as we have a valid value for "radius".
                        break;
                    }
                    else
                    {
                        //Following code block writes in terminal window that the input could not be read and how to try again. Then waits for user to press any key to restart loop ("while (true)").
                        Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst hele tal fra ti-tals systemet.");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();

                    }

                }

                //Sets variable "radius1" to "double" version of "string" "radius".
                radius1 = Convert.ToDouble(radius);

                //Calculates the surface of the cirkel and sets it as value for "areal" - "Math.PI" is the value for π (called pi) and "Math.Pow" is a "raise a number to a power" command that will take the first number in the parentheses (called the base) and multiply it with it self as many times as the second number in the parentheses (called the exponent) indicates. 
                areal = Math.PI * Math.Pow(radius1, 2);

                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "areal" is the result of the previous calculation and is called by "$" and "{}".
                Console.WriteLine($"Arealet af cirklen er {areal}");

                //Calculates the circumference of the circle and sets it as value for "omkreds" - "Math.PI" is the value for π (called pi).
                omkreds = 2 * radius1 * Math.PI;

                //Writes "TEXT" in terminal at current cursor position and changes to next terminal line after finishing the code line. The variable "omkreds"" is the result of the previous calculation and is called by "$" and "{}".
                Console.WriteLine($"\nOmkredsen af cirklen er {omkreds}");

                //Waits for user input:
                Console.WriteLine("Tryk en tast:");
                Console.ReadKey();
                break;

            } while (true);
        }




        //Method TabelMenu.
        public static void TabelMenu()
        {


            //Initializes and sets variable.
            string tmvalg = "0";

            //
            do
            {

                //Clears terminal screen.
                Console.Clear();
                //
                Console.WriteLine("Velkommen til tabel visning");
                Console.WriteLine("\nDu kan vælge mellem følgende:");
                Console.WriteLine("\nVisning af tabel med indtastet tal (tryk t)");                
                Console.WriteLine("\nAfslutning af program (tryk a)");
                tmvalg = Console.ReadLine().ToLower();

                //
                if (tmvalg == "t")
                {
                    HjemmeOpgaveWorkshoppenv2.TabelVisning();
                }
                                
                //
                else if (tmvalg == "a")
                {
                    HjemmeOpgaveWorkshoppenv2.AfslutMenu();
                }

                //
                else
                {
                    Console.WriteLine("Din indtastning kunne ikke læses. Prøv igen og brug venligst kun t eller a og afslut med tryk på enter eller return.");
                    Console.WriteLine("Tryk en tast for at prøve igen!");
                    Console.ReadKey();
                }

            } while (tmvalg != "t" && tmvalg != "a");
        }

        //Method TabelVisning.
        public static void TabelVisning()
        {
            //Initializes variables and pre-sets them.
            int wishtal = 0;
            int wishtalcalc = 0;

            //Clears terminal screen.
            Console.Clear();
            //Writes "TEXT" in terminal at current cursor position- the "Line" part in WriteLine changes to next terminal line after finishing the code line.
            Console.WriteLine("Velkommen til Tabel Programmet- her kan du indtaste et tal og få vist * tabellen op til 20 * for det.");
            Console.WriteLine("Indtast dit tal (brug venligst kun hele tal):");
            //Reads user input and sets it as value for string variable "wishtal".
            wishtal = Convert.ToInt32(Console.ReadLine());
            //Initializes variable "i" as integer and sets it to 1, then checks condition (if "i" is smaller or equal to 20) and if yes runs loop "for" adding 1 to value of "i" at the end of loop run and starts over at checking condition.
            for (int i = 1; i <= 20; i++)
            {
                //Calculates "wishtalcalc" - the result of current value of "i" times original user input "wishtal".
                wishtalcalc = wishtal * i;
                //Cheks if ("if") "i" is equal to or less than 9 so it ads a space before printing ("Console.WriteLine") "i", if not ("else") does not.
                if (i <= 9)
                {
                    //Writes part of table to terminal (adding space before "i" for viewing pleasure). "$" and "{}" calls variables and "\n" jumps to new line.
                    Console.WriteLine($"\n {i}   *   {wishtal}   =      {wishtalcalc}");
                }
                else
                {
                    //Writes part of table to terminal. "$" and "{}" calls variables and "\n" jumps to new line.
                    Console.WriteLine($"\n{i}   *   {wishtal}   =      {wishtalcalc}");
                }
            }
            //Tells user to press a key to finish.
            Console.WriteLine("\nTryk en tast for at afslutte");
        }

        //Method AfslutMenu.
        public static void AfslutMenu()
        {
            //
            //Bye.

            return;

        }
    }
}
