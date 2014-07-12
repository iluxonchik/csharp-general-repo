using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Polymorphism *****");
            // Make an array of Shape-compatible objects
            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Andre"), new Circle("Jane"),
                               new Hexagon("Kate")};

            // Loop over each item and interact with the polymorphic interface
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            // This calls the Draw() method of the ThreeDCircle
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();

            // This calls the Draw() method method of the parent!
            ((Circle)o).Draw();

            Console.ReadLine();
        }
    }
}
