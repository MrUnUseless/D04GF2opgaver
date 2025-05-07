using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04GF2opgaver.Opgaver
{
    class Opgave56
    {
        //Class level setup part: Initializes and/or sets/presets variables.

        //Array for input of temperature measurements- predefined for 7 inputs.
        public static double[] TemperatureMeasurementsArray = new double[7];

        //Array for days of the week- predefined for 7 days (quite fitting I'd say).
        public static string[] WeekDays = { "Mandag ", "Tirsdag", "Onsdag ", "Torsdag", "Fredag ", "Lørdag ", "Søndag " };

        //Initializes and sets "TemperaturInputAmount". This can be changed if another amount of measurements is desired.
        public static int TemperaturInputAmount = 7;

        //Initializes and presets "StartDag" to empty. Used in "ArreyDaySelector".
        public static string StartDag = "";

        //Initializes and presets "TestNumberConverted". Used in "TemperatureArrayFiller".
        public static double TestNumberConverted = 0;

        //Initializes "SelectedDay". Used in "ArreyDaySelector".
        public static int SelectedDay;

        //Initializes "SelectedCounter". Used in "Opgaverun" result display section as counter.
        public static int SelectedCounter;

        //Initializes "TemperatureAverage".Used in "Opgaverun" result display section to display result of sum of Temperatures.
        public static double TemperatureAverage;

        //Initializes and presets value of "Aproved" which is stop-condition for "try-catch" loop (in "TemperatureArrayFiller") which checks validity of user-input "Testnumber" (temperature).
        public static bool Approved = false;
        
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
                Console.WriteLine("Velkommen til et meget gennemsnitligt temperatur-beregnings program\n(og ja- det er ligeså spændende som det lyder).");
                Console.WriteLine("Her kan du beregne gennemsnittet af 7 temperaturmålinger over 7 dage.\nFørst indtastes startdagen, derefter indtastes temperaturerne.");
                Console.WriteLine("Tryk en tast for at gå til første indtastnings modul:\n");
                Console.ReadKey();
                Console.Clear();

                //Calls "ArreyDaySelector" that sets starting day.
                ArreyDaySelector();

                Console.WriteLine($"Du valgte {WeekDays[SelectedDay]} som startdag.\nTryk en tast for at fortsætte.");
                Console.ReadKey();


                //Calls "TemperatureArrayFiller" that fills "TemperatureMeasurementsArray" with data.
                TemperatureArrayFiller();
                
                //Sets variable "SelectedCounter" according to "SelectedDay".
                SelectedCounter = SelectedDay;

                //Clears console and displays status and results.
                Console.Clear();
                for (int i = 0; i <= TemperaturInputAmount - 1; i++ )
                {
                    //Cheks to see if "SelectedCounter" is greater than 6 (the last index of the array). If so, it resets it to 0.
                    if (SelectedCounter > 6)
                    {
                        SelectedCounter = 0;
                    }

                    //Displays the weekdays acoording to temperature measurements in the order they were taken.
                    Console.WriteLine($"\n{WeekDays[SelectedCounter]} var temperaturen: {TemperatureMeasurementsArray[i]}");

                    //Increments "SelectedCounter" by 1.
                    SelectedCounter = ++SelectedCounter;

                }
                //Calculating temperature average output and then displaying it.
                TemperatureAverage = (TemperatureMeasurementsArray.Sum()/TemperaturInputAmount);
                Console.WriteLine($"\nGennemsnits temperatur:   {TemperatureAverage:N1}");
                Console.WriteLine("\nTryk en tast for at afslutte.");
                
                //Sets "IsRunning" to false ending loop (and thus method).
                IsRunning = false;

            } while (IsRunning); //When not true ends main loop of this method.

        }//End method "Opgaverun".

        //**NEW METHOD**

        //Start method "ArreyDaySelector".
        public static void ArreyDaySelector()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Initializes and presets "do-while" (day selection) condition.
            bool DaySelecterRunning = true;

            //Starts main loop of this method.
            do
            {
                //Runs switch case loop using value "StartDag" to check input and get valid day to use for setting "SelectedDay" which defines corresponding day for output.
                Console.Clear();
                Console.WriteLine("Indtast venligst startdag som nummer (1 for mandag, 2 for tirsdag osv.):\n\n");
                StartDag = Console.ReadLine().ToLower();

                switch (StartDag)
                {
                    case "1":

                        SelectedDay = 0;
                        DaySelecterRunning = false;
                        break;

                    case "2":

                        SelectedDay = 1;
                        DaySelecterRunning = false;
                        break;

                    case "3":

                        SelectedDay = 2;
                        DaySelecterRunning = false;
                        break;

                    case "4":

                        SelectedDay = 3;
                        DaySelecterRunning = false;
                        break;

                    case "5":

                        SelectedDay = 4;
                        DaySelecterRunning = false;
                        break;

                    case "6":

                        SelectedDay = 5;
                        DaySelecterRunning = false;
                        break;

                    case "7":

                        SelectedDay = 6;
                        DaySelecterRunning = false;
                        break;

                    default:

                        /*Following code block writes in console window that the input could not be read and how to try again.
                        Then waits for user to press any key to restart loop.*/
                        Console.WriteLine("Din indtastning kunne ikke læses.\nPrøv igen og brug venligst hele tal fra 1 til 7.\n");
                        Console.WriteLine("Tryk en tast for at prøve igen!");
                        Console.ReadKey();
                        break;

                }

            } while (DaySelecterRunning);//When not true ends do-while (main loop) of this method.

        }//End method "ArreyDaySelector".

        //**NEW METHOD**

        //Start method "TemperatureArrayFiller".
        public static void TemperatureArrayFiller()
        {
            //Method level setup part: Initializes and/or sets/presets variables.

            //Initializes and presets "do-while" (input "TestNumber" check run and filling of "TemperatureMeasurementsArray") condition.
            bool ArrayFillingRunning = true;        

            //Initializes "Testnumber" which is user-input (temperature).
            string TestNumber;

            //Starts main loop of this method.
            do
            {
                //Runs "for" loop until array "TemperatureMeasurementsArray" is filled with data according to "TemperaturInputCounter" vs "TemperaturInputAmount" (pre-defined input amount).
                for (int TemperaturInputCounter = 0; TemperaturInputCounter <= TemperaturInputAmount - 1; TemperaturInputCounter++)
                {
                    //Initializes and presets value of "Aproved" which is stop-condition for "try-catch" loop.
                    Approved = false;
                    //Clears console, instructs user and reads user input.
                    Console.Clear();
                    Console.WriteLine("Velkommmen til temperatur indtastnings modulet. Her kan du indtaste temperaturerne.");
                    Console.WriteLine("\nIndtast dem i den rækkefølge de er taget så de passer med ugedagene.\n");
                    Console.WriteLine($"\nIndtast temperatur nr. {TemperaturInputCounter + 1}:");

                                        
                    //Chekcks if input is a valid number.
                    while (!Approved)
                    {
                        
                        Console.WriteLine("OBS! Komma vil blive ignoreret. Ved kommatal brug punktum.");
                        Console.WriteLine("\nIndtast et tal:\n");
                        TestNumber = Console.ReadLine();

                        try
                        {
                            TestNumberConverted = Convert.ToDouble(TestNumber);
                            Approved = true;
                        }

                        catch
                        {
                            Console.Write("Det er ikke et gyldigt tal - Tryk enter.");
                            Console.ReadKey();
                            Console.Clear();
                        }

                    }// "Approved = true" ends "while" loop when input is correct ("TestNumber" is a valid number).

                    //Stops "for-while" by setting "ArrayFillingRunning" to false once last karakter has had its' input.
                    if (TemperaturInputCounter == TemperaturInputAmount - 1)
                    {
                        ArrayFillingRunning = false;
                    }

                    //Adds dataset "TestNumberConverted" to array "TemperatureMeasurementsArray" using "TemperaturInputCounter" as enumeration counter.
                    TemperatureMeasurementsArray[TemperaturInputCounter] = TestNumberConverted;
                }

            } while (ArrayFillingRunning);//When not true ends do-while (main loop) of this method.

        }//End method "TemperatureArrayFiller".               
    }
}

