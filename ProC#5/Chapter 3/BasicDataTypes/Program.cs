using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclaration();
            NewingDataTypes();
            Console.ReadLine();
        }

        static void LocalVarDeclaration()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;
            string myString;
            myString = "This is a string!";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine(" => Using new to create variables:");
            bool b = new bool(); // set to false
            int i = new int(); // set to 0
            double a = new double(); // set to 0
            DateTime dt = new DateTime(); // set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, a, dt);
            Console.WriteLine();
        }
    }
}
