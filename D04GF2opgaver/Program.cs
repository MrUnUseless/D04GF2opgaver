using D04GF2opgaver.Opgaver;

namespace D04GF2opgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here the numbers or names before or after Opgave can be changed to call and run different Opgaver 
            Opgave31.OpgaveRun();
            //Makes the program wait for user input (in this case press any key) in the terminal before progressing.
            Console.ReadKey();
        }
    }
}
