using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Interfaces *****\n");
            // Call Points property defined by IPointy
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            // Catch possible InvalidCastException
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;

            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // Cam we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Jason");
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
                Console.WriteLine("Points: {0}", itfPt2.Points);
            else
                Console.WriteLine("OOOOPS! Not pointy...");


            // Make an array of Shapes
            Shape[] someShapes = { new Hexagon(), new Circle(), new Triangle("Joe"),
                                 new Circle("JoJO") };

            for (int i = 0; i < someShapes.Length; i++)
            {
                someShapes[i].Draw();

                // Who's pointy?
                if (someShapes[i] is IPointy) // with "is" it will return true or false
                    Console.WriteLine("-> Points: {0}", ((IPointy)someShapes[i]).Points);
                else
                    Console.WriteLine("-> {0}\'s not Pointy!", someShapes[i].PetName);
            }

                Console.ReadLine();
        }
    }
}
