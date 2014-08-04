using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();

            // Hand over each car in the collection
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going at {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.ReadLine();
        }
    }
}
