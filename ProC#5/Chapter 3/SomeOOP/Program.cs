using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call to turn the radio on/off is done internally
            Car aCar = new Car();
            aCar.TurnOnRadio(false);

            Shape [] someShapes = new Shape[3];
            someShapes[0] = new Hexagon();
            someShapes[1] = new Circle();
            someShapes[2] = new Hexagon();

            foreach (Shape s in someShapes)
         		{
         			// Use the polymorphic interface!
         			s.Draw();
         		}

         		Console.ReadLine();
        }
    }
}
