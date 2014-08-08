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
        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string PetName) { X = xPos; Y = yPos; desc.PetName = PetName; }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        // Override Object.ToString()
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Name = {2};\nID = {3}\n", X, Y, desc.PetName, desc.PointID);
        }

        // Return a copy of the current object
        public object Clone()
        {  
            // First get a shallow copy
            Point newPoint = (Point)this.MemberwiseClone();

            // Clone the reference vars
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }
    }

    // This class describes a point
    public class PointDescription
    {
        public string PetName { get; set; }
        public Guid PointID { get; set; }

        public PointDescription()
        {
            PetName = "No-Name";
            PointID = Guid.NewGuid();
        }
    }
}
