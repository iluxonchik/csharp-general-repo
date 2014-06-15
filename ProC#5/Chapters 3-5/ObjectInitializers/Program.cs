using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Object Init Syntax *****\n");

            // Make a Point by setting each property manually
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            // Or make a Point via a custom constructor
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Or make a Point using object init syntax
            // Behind the scenes, the type's default constructor is invoked, 
            // followed by setting the values to the specified properties.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            // Calling another constructor with init sytax
            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            // Create and initialize a Rectangle
            Rectangle aRect = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 200, Y = 200 }
            };

            Console.ReadLine();
        }
    }
}
