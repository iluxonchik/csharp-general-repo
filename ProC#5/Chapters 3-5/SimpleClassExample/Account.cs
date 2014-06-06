using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Account
    {
        // Instance level data
        public double currBal;

        // A static point data
        public static double currIntRate;
        public Account(double balance)
        {
            currBal = balance;
        }

        static Account()
        {
            Console.WriteLine("In static ctor!");
            currIntRate = 0.04;
        }

        // Static members to get(set the int rate
        public static void SetIntRate(double newRate)
        {
            currIntRate = newRate; // this.currIntRate won't work, since currIntRate is marked as static (also the method is static)
        }

        public static double GetIntRate()
        {
            return currIntRate;
        }
    }
}
