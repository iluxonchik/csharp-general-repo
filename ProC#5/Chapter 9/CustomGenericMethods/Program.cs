﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Generic Methods *****\n");

            // Swap 2 ints
            int a = 10, b = 11;
            Console.WriteLine("Before swap: {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            // Swap 2 strings
            string s1 = "Hello", s2 = "Bye";
            Console.WriteLine("Before swap: {0}, {1}", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0}, {1}", s1, s2);

            Console.ReadLine();

        }

        // This method will swap any two items
        // as specified by the paremeter <T>.
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}
