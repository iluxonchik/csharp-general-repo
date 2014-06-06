using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    struct Point
    {
        // Fields of the structure
        public int x;
        public int y;

        // A custom constructor
        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }

        public void Increment()
        {
            x++; y++;
        }

        public void Decrement()
        {
            x--; y--;
        }

        public void Display()
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }
    }

    struct Rectangle
    {
        // The Rectangle structure contians a reference type member.
        public ShapeInfo rectInfo;

        public int rectTop, rectLeft, rectBottom, rectRight;

        // Custom constructor.
        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top; rectBottom = bottom;
            rectLeft = left; rectRight = right;
        }

        public void Display(){
            Console.WriteLine("String = {0}, Top = {1}, Bottom = {2}, " +
                 "Left = {3},  Right = {4}", rectInfo.infoString, rectTop, rectBottom, rectLeft, rectRight);
        }
    }

    class ShapeInfo
    {
        public string infoString;

        // Custom constructor.
        public ShapeInfo(string info)
        {
            infoString = info;
        }
    }

    //Classes are always reference types.
    class PointRef
    {
        // Fields of the structure
            public int x;
            public int y;

            // A custom constructor
            public PointRef(int xPos, int yPos)
            {
                x = xPos;
                y = yPos;
            }

            public void Increment()
            {
                x++; y++;
            }

            public void Decrement()
            {
                x--; y--;
            }

            public void Display()
            {
                Console.WriteLine("x = {0}, y = {1}", x, y);
            }
        
    }
    class Program
    {

        static void Main(string[] args)
        {
            ValueTypeAssignment();
            ReferenceTypeAssignment();
            
            // Create the first rectangle
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is some new info!";
            r2.rectBottom = 1245;

            // Print both of the rectangles.
            r1.Display();
            r2.Display();

            Console.ReadLine();
        }

        // Assigning two intrinsic value types results in
        // two independent variables on the stack.
        static void ValueTypeAssignment()
        {
            Console.WriteLine("Assigning the value types\n");

            Point p1 = new Point(10, 10);
            Point p2 = p1; // a new copy of p1 is created and assigned to p2

            p1.Display();
            p2.Display();

            // Change p1.y and print again. p2.y is not changed
            p1.y = 99;

            Console.WriteLine("\n=> Changed p1.y\n");
            p1.Display();
            p2.Display();
        }

        static void ReferenceTypeAssignment()
        {
            Console.WriteLine("Assigning reference types\n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1; // p2 now POINTS to the location in memory of p1

            // Print both refs.
            p1.Display();
            p2.Display();

            // Change p1.y and print again
            p1.y = 99;
            Console.WriteLine("\n=> p1.y changed\n");
            p1.Display();
            p2.Display();

            // In this case there are two references pointing to the same
            // object on the managed heap.
        }
    }
}
