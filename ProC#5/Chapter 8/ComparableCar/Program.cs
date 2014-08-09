using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomEnumerator;
using System.Collections;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun With Object Sorting \n");

            // Make an array of Car objects
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Raaa", 30, 4);
            myAutos[1] = new Car("Rusty", 80, 1);
            myAutos[2] = new Car("La", 40, 234);
            myAutos[3] = new Car("Viper", 40, 34);
            myAutos[4] = new Car("Ma", 40, 5);

            // Display current array
            Console.WriteLine("Unordered: ");
            foreach(Car c in myAutos)
                Console.WriteLine("{0} {1}",c.CarID, c.PetName);

            // Sort them
            Array.Sort(myAutos);
            Console.WriteLine();

            // Display the sorted array
            Console.WriteLine("Ordered: ");
            foreach(Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);

            // Now sort by pet name
            Array.Sort(myAutos, Car.SortByPetName); // or Array.Sort(myAutos, new PetNameComparer());
            

            // Dump the sorted array
            Console.WriteLine("Ordering by pet name: ");
            foreach(Car c in myAutos)
                Console.WriteLine("{0} {1}", c.CarID, c.PetName);
            Console.ReadLine();
        }

        // This **helper class** is used to sort an array of Cars by pet name
        public class PetNameComparer : IComparer
        {
            // Test the pet name of each object
            int IComparer.Compare(object o1, object o2)
            {
                Car t1 = o1 as Car;
                Car t2 = o2 as Car;
                if (t1 != null && t2 != null)
                    return String.Compare(t1.PetName, t2.PetName);
                else
                    throw new ArgumentException("Parameter is not a Car!");
            }
        }
    }

}
