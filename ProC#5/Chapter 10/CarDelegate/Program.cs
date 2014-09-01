﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Delegates as even enablers ****\n");

            // First, make a car object
            Car c1 = new Car("SlugBug", 100, 10);

            // Now, tell the car which method to call when it wants to send us messages
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent2));

            // Speed up (this will trigger the events)
            Console.WriteLine("**** Speeding UUUUUUP! *****\n");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        // This is the target for incoming events
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n **** Message From Car Object ****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("**********************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("=> {0}", msg.ToUpper());
        }
    }
}
