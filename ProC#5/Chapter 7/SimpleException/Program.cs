using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Exception Example *****");
            Console.WriteLine("=> Creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);
            
            // Speed up past the car's max speed
            // to trigger the exception
            try 
            { 
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
                // TargetSite actually returns a MethodBase object
            catch (Exception e)
            {
                Console.WriteLine("\n*** ERROR! ***");
                Console.WriteLine("Mamber name: {0}", e.TargetSite);
                Console.WriteLine("Class of defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Stack: {0}", e.StackTrace);
                Console.WriteLine("Method: {0}",e.TargetSite);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("\n-> Custom Data:");
                if (e.Data != null) // be default e.Data is null
                {
                    foreach (DictionaryEntry de in e.Data)
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                }
            }

            // The error has been handled, processing continues with the next statement
            Console.WriteLine("\n**** Out Of Exception Logic *****");
            Console.ReadLine();
        }
    }
}
