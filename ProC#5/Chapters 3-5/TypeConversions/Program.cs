﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Type Conversions ****");
           
            // Add two shorts and print the result
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1,numb2));

            short numb3 = 30000, numb4 = 30000;

            unchecked
            {
                // Explicitly cast an int into a short (and allow loss of data)
                short answer = (short)Add(numb3, numb4);
                Console.WriteLine("{0} + {1} = {2}", numb3, numb4, answer);
            }
            

            NarrowingAttempt();
            ProcessBytes();
            DeclareImplicitVars();
            LinqQueryOverInts();
            SwitchOnStringExample();

            Console.ReadLine();

        }

        static int Add(int x, int y)
        {
            // The compiler won't complain if shorts are provided as arguments,
            // because a short fits in an int for sure (implicit upward cast)
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte aByte = 0;
            int anInt = 200;

            // Explicitly cast an into into a byte (no loss of data)
            aByte = (byte)anInt;
            Console.WriteLine("Value of aByte: {0}", aByte);
        }

        static void ProcessBytes()
        {
            byte b1 = 100;
            byte b2 = 250;

            // Tell the compiler to add CIL code
            // to throw an exception if overflow/undeflow
            // occures
            try
            {
                byte sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Force overflow checking over a block of code statements
            try
            {
                checked
                {
                    byte anotherSum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", anotherSum);
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Assuming that /checked is enabled
            // this block will not trigger a runtime
            // exception
            unchecked
            {
                byte yetAnotherSum = (byte)(b1 + b2);
                Console.WriteLine("sum = {0}", yetAnotherSum);
            }
        }

        static void DeclareImplicitVars()
        {
            // Implicitly typed local varibles
            var anInt = 0;
            var aBool = true;
            var aString = "This is a string!";

            // Print out the underlying data type
            Console.WriteLine("anInt is a: {0}", anInt.GetType().Name);
            Console.WriteLine("aBool is a: {0}", aBool.GetType().Name);
            Console.WriteLine("aString is a: {0}", aString.GetType().Name);
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            
            //LINQ Query
            var subset = from i in numbers where i < 10 select i;

            Console.WriteLine("Values in subset:");
            foreach (var i in subset)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine();

            // What type is a subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }

        void SwitchOnStringExamaple()
        {
            Console.WriteLine("C# or VB");
            string langChoice = Console.ReadLine();

            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a nice language!");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Neither C# nor VB? Aight then...");
                    break;
            }
        }
    }

    
}
