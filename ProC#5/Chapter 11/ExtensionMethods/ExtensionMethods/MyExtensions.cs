using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensionMethods
{
    static class MyExtensions
    {
        // All objects will be able to use this method (this "object")
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here => {1}\n", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        // All ints will be able to use this method (this "int")
        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);

            return Int32.Parse(new String(digits));
        }
    }
}
