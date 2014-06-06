using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUnityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Static Classes ****\n");

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            Console.ReadLine();
        }
    }
}
