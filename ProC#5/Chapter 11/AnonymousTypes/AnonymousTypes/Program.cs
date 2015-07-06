using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildAnonType("Lolo", "Blue", 700);
        }

        static void BuildAnonType(string make, string color, int currSpeed)
        {
            // Build annon type using incoming args
            var car = new { Make = make, Color = color, Speed = currSpeed };
            Console.WriteLine("{0}, {1}, {2}", car.Make, car.Color, car.Speed);

            Console.WriteLine("ToString = {0}", car.ToString());
        }
    }
}
