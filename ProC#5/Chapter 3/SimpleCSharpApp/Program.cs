using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    // The clas that defines the Main() method is termed the application object
    class Program // This class can be renamed
    {
        //the Main() method is the entry point of the application
        static int Main(string[] args)
        {
            // Display  a simple message in the console
            Console.WriteLine("**** Console Message ****");
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            //The Console class is define within the System namespace
            // Wait for the Enter key before closing the console
            Console.ReadLine();

            // Return an arbitrary error code
            return 0;
        }
    }
}