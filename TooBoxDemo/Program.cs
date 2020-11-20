using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooBoxDemo
{
    class Program
    {
        static void Main(string[] args) //The Main method acts as our program's .exe file, aka executable or "entry point". This is the file we double click on to start any program.
        {
            Console.WriteLine("Welcome to your Tool Box!");
            Console.WriteLine("You can either hit\"Y\" then ENTER to continue, or hit \"N\" then ENTER to Clear the Console and Continue.");
           
            string userResponse = Console.ReadLine();
            if (userResponse == "Y")
            {
                KeyToContinue();
            }
            else if (userResponse == "N")
            {
            KeyToContinueWithClearConsole();
            }
            else
            {
                Console.WriteLine("Not sure friend, but I'll going to close the program when you hit ENTER");
            }
            
            Console.ReadLine();




            //Functions are methods written outside of a custom class
            //Methods are functions written inside of a custome class


            //Functions below this line
            void KeyToContinue()
            {
             Console.WriteLine("Hit ENTER to continue on with the code...");
             Console.ReadLine();
            }

            void ClearConsole()
            {
             Console.Clear();
            }

            void KeyToContinueWithClearConsole()
            {
                KeyToContinue();
                ClearConsole();
             Console.WriteLine("Congratulations! You've cleared the console!... hit ENTER to close the program");
                Console.ReadLine();
            }
        }
    }
}
