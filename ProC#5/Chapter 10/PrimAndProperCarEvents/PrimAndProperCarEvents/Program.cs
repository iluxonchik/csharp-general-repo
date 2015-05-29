using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimAndProperCarEvents
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

        public static void CarAboutToBlow(object sender, CarEventArgs e) { Console.WriteLine(e.msg); }
        public static void CarIsAlmostDoomed(object sender, CarEventArgs e) { Console.WriteLine("=> Critical: {0}", e.msg); }
        public static void CarExoloded(object sender, CarEventArgs e) { Console.WriteLine(e.msg); }
    }
}
