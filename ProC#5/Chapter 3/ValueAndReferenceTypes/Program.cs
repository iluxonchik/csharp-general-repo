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
