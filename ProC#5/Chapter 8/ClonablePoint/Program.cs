using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClonablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Object Cloning *****\n");
            // Two referrences pointing to the same object
            Point p1 = new Point(50, 50);
            Point p2 = p1;
            p2.X = 0;

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();

            // Change p4.X, which will not change p3.X, since p3 was cloned
            p4.X = 421;

            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.ReadLine();
        }
    }

    public class Point: ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        // Override Object.ToString()
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}", X, Y);
        }

        // Return a copy of the current object
        public object Clone()
        {  
            // Copy each field of the Point, member by member
            return this.MemberwiseClone();
            // return new Point(this.X, this.Y); would work too! 
        }
    }
}
