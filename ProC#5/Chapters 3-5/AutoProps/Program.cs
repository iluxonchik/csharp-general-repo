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
            c.DispayStats();

            // Put car in garage
            Garage g = new Garage();
            g.AnAuto = c;
            Console.WriteLine("Number of cars in garage: {0}", g.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", g.AnAuto.PetName);

            Car b = new Car();
            b.DispayStats();
            Garage h = new Garage(b, 1);
            Console.WriteLine("Number of cars in garage: {0}", h.NumberOfCars);
            Console.WriteLine("Your car is named: {0}", h.AnAuto.PetName);

           

            Console.ReadLine();
        }
    }
}
