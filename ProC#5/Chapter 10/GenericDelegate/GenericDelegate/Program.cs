using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{   
    // This generic delegate can call any method
    // retutning void and taking a single type parameter
    public delegate void MyGenericDelegare<T>(T arg);
    class Program
    {
        static void Main(string[] args)
        {
            MyGenericDelegare<string> stringTarget = new MyGenericDelegare<string>(StringTarget);
            MyGenericDelegare<int> intTarget = new MyGenericDelegare<int>(IntTarget);

            stringTarget("Hello");
            intTarget(2);
        }

        static void StringTarget(string str)
        {
            Console.WriteLine(str);
        }

        static void IntTarget(int i)
        {
            Console.WriteLine("ix2={0}", i*2);
        }
    }
}
