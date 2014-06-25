using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            // Make a Car object and set max speed
            Car aCar = new Car(80);

            // Set the current speed and print it
            aCar.Speed = 50;
            Console.WriteLine("The car is going on {0} MPH", aCar.Speed);
            Console.ReadLine();
        }
    }
}
