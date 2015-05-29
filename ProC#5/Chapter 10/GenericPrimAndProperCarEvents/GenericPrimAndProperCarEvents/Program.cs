using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrimAndProperCarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Prim And Proper Events *****");
            Car c1 = new Car("Vroom", 100, 10);

            // Register event handlers
            c1.AboutToBlow += CarAboutToBlow;
            c1.AboutToBlow += CarIsAlmostDoomed; // Group conversion syntax

            EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExoloded);
            c1.Exploded += d;

            for(int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            c1.Exploded -= d;

            for(int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
        }

        public static void CarAboutToBlow(Object sender, CarEventArgs args) { Console.WriteLine(args.msg); }
        public static void CarIsAlmostDoomed(Object sender, CarEventArgs args) { Console.WriteLine("=> Critical: {0}", args.msg); }
        public static void CarExoloded(Object sendere, CarEventArgs args) { Console.WriteLine(args.msg); }
    }
}
