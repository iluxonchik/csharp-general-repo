using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnsafeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;
            SafeSwap(ref i, ref j);
            Console.WriteLine("{0}, {1}", i, j);
            unsafe { UnsafeSwap(&i, &j); }
            Console.WriteLine("{0}, {1}", i, j);
        }

        unsafe public static void UnsafeSwap(int* i, int* j)
        {
            int temp = *i;
            *i = *j;
            *j = temp;
        }

        public static void SafeSwap(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }
}
