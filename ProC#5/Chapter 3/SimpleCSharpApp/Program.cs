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
            // Helper method within the Program class
            ShowEnvironmentDetails();
            //The Console class is define within the System namespace
            // Wait for the Enter key before closing the console
            Console.ReadLine();

            // Return an arbitrary error code
            return 0;
        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine
            // as well as some other details

            foreach(string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive : {0}", drive);

            Console.WriteLine("OS : {0}",  Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
        }
    }
}