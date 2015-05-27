using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegateMethodGoupConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Method Group Conversion *****");
            Car c1 = new Car();

            // Register the simple method name
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speeding Up *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            // Unregister with simple method name
            c1.UnregisterWithCarEngine(CallMeHere);

            // No more notifications
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
        }
        
        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }
    }
}
