﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            // Point using ints
            Point<int> p = new Point<int>(10, 10);
            Console.WriteLine(p.ToString());
            p.ResetPoint();
            Console.WriteLine(p.ToString());
            Console.WriteLine();

            // Point using double
            Point<double> p2 = new Point<double>(4.4, 3.3);
            Console.WriteLine(p2.ToString());
            p2.ResetPoint();
            Console.WriteLine(p2.ToString());
            Console.WriteLine();

            Console.ReadLine();
        }

        public struct Point<T>
        {
            // Generic state date
            private T xPos;
            private T yPos;

            // Generic constructor
            public Point(T xVal, T yVal)
            {
                xPos = xVal;
                yPos = yVal;
            }

            // Generic properties
            public T X
            {
                get { return xPos; }
                set { xPos = value; }
            }

            public T Y
            {
                get { return yPos; }
                set { yPos = value; }
            }

            public override string ToString()
            {
                return string.Format("[{0}, {1}]", xPos, yPos);
            }

            // Reset fields to the default value of the parameter
            public void ResetPoint()
            {
                xPos = default(T);
                yPos = default(T);
            }
        }
    }
}
