﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage carLot = new Garage();

            // Get items using the GetEnumerator()
            foreach (Car c in carLot) // same as ( Car c in carLot.GetEnumerator() )
            {
                Console.WriteLine("{0} is goinf {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.WriteLine();

            // Get items in reverse using named iterator
            foreach (Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is goinf {1} MPH", c.PetName, c.CurrentSpeed);
            }

            Console.ReadLine();
        }
    }
}
