using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForEachExample();

            Console.ReadLine();
        }

        // A basic for loop
        static void ForLoopExample()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("The number is: {0} ", i);
            }

            Console.WriteLine();
        }

        // Iterate array items using foreach
        static void ForEachExample()
        {
            string [] carTypes = {"BMW", "Mercedes", "McLaren", "Ferrari", "Lamborghini"};
            foreach (string c in carTypes)
                Console.WriteLine(c);

            int[] someInts = { 10, 20, 30, 40 };
            foreach (int i in someInts)
            Console.WriteLine(i);

            Console.WriteLine();
        }
    }
}
