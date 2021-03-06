﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Allocate and configure a Car object
            Car aCar = new Car();
            aCar.petName = "Meowings";
            aCar.currSpeed = 10;

            for (int i = 0; i <= 10; i++)
            {
                aCar.SpeedUp(5);
                aCar.PrintState();
            }

            Console.WriteLine("\n**** Fun With Static Data ****");
            Account a1 = new Account(50);
 
            // Print the current intRate
            Console.WriteLine("Int Rate: {0}", Account.GetIntRate());

            // Try to change the int rate via property
            Account.SetIntRate(0.08);

            // Make a second account
            Account a2 = new Account(100);

            Console.WriteLine("Int Rate: {0}", Account.GetIntRate());

            Console.ReadLine();
        }
    }
}
