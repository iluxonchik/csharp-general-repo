using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Automatic Properties *****\n");

            Car c = new Car();
            c.PetName = "A Car";
            c.Speed = 978;
            c.Color = "Blue";

            Console.WriteLine("Your car is named {0}? Okay then...", c.PetName);
            c.DispayStats();

            Console.ReadLine();
        }
    }
}
