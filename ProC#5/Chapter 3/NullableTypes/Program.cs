using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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
