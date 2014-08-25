﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    // This delegate can point to any method,
    // taking two integers and returning an integer
    public delegate int BinaryOp(int x, int y);

    // This class contains methods BinaryOp will point to.
    public class SimpleMath
    {
        public static int Add(int x, int y)
        { return x + y; }
        public static int Subtract(int x, int y)
        { return x - y; }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("**** Simple Delegate Example *****\n");

                // Create a BinaryOp delegate that "points to" SimpleMath.Add();
                BinaryOp b = new BinaryOp(SimpleMath.Add);

                // Invoke Add() method directly using delegate object
                Console.WriteLine("10 + 10 is {0}", b(10, 10)); // b.Invoke(10, 10) would also work here
                Console.ReadLine();
            }
        }
    }
}
