using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{

    class DatabseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }

        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        { return boolValue; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Nullable Data ****\n");
            DatabseReader dr = new DatabseReader();

            // Get int from database
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                // If i is not null.
                Console.WriteLine("Value of i is: {0}", i);
            else
                Console.WriteLine("Value of i is undefined.");

            // Get bool from database
            bool? b = dr.GetBoolFromDatabase();
            if (b!=null)
                Console.WriteLine("Value of b is: {0}", b);
            else
                Console.WriteLine("b is undefined");

            // If dr.GetIntFromDatabse() is null, assign 100 to i
            int someData = dr.GetIntFromDatabase() ?? 100; // note here "int?" is not necessary, since "someData" will not be assigned null
            Console.WriteLine("Value of someData is: {0}", someData);

            Console.ReadLine();
        }

        static void LocalNullableVars()
        {
            // Define some local nullable variables
            int? nullableInt = 10;
            double? nullableDouble = 3.21;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int? [] arrayOfNullableInts = new int?[10];

            // the **?** notation is a shorthand for creating an instance 
            // of the generic **System.Nullable<T>** structure type.
            System.Nullable<int> anotherNullableInt = null;
            System.Nullable<double> anotherNullableDouble = null;
        }
    }
}
