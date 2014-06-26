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
            
            // Make a MiniVan object
            MiniVan aVan = new MiniVan();
            aVan.Speed = 10;
            Console.WriteLine("The MiniVan is going at {0}", aVan.Speed);
            /* 
             * ERROR: Can't access private members
             * aVan.currSpeed = 55;
             */


            Console.ReadLine();
        }
    }
}
