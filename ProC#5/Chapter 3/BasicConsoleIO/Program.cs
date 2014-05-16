using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            FormatNumericalData();
            Console.ReadLine(); // read the info from input until Enter key is pressedc
            
         }

        static void GetUserData()
        {
            // Get some info
            Console.WriteLine("Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Number: ");
            string userNumer = Console.ReadLine();

            // Change the echo colour
            ConsoleColor prevColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo info to the console
            Console.WriteLine("Hello, {0}! The number you entered is {1}.", userName, userNumer);

            // Restore previous colour
            Console.ForegroundColor = prevColour;
        }

        static void FormatNumericalData()
        {
            Console.WriteLine("The value of 99999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
        
       
    }
}
