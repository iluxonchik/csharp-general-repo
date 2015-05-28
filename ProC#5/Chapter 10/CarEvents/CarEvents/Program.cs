using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Events *****");
            Car c1 = new Car("Vroom", 100, 10);
            c1.AboutToBlow += new Car.CarEngineHandler(CarAboutToBlow);
            c1.AboutToBlow += CarIsAlmostDoomed; // Group conversion syntax

            Car.CarEngineHandler d = new Car.CarEngineHandler(CarExoloded);
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

        public static void CarAboutToBlow(string msg) { Console.WriteLine(msg); }
        public static void CarIsAlmostDoomed(string msg) { Console.WriteLine("=> Critical: {0}", msg); }
        public static void CarExoloded(string msg) { Console.WriteLine(msg); }
    }
}
