﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // Circle DOES NOT override Draw().
    // If we did not implement the abstract Draw() method, Circle would also be
    // considered abstract, and would have to be marked abstract!
    class Circle : Shape
    {
        public Circle() { }
        public Circle( string name ) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }


    // Hexagon DOES override Draw().
    // Hexagon now implements IPointy
    class Hexagon : Shape, IPointy
    {
        public Hexagon() { }
        public Hexagon( string name ) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
        public byte Points { get { return 6; } }
    }

    // This class extends Circle and hides the inherited Draw() method.
    class ThreeDCircle : Circle
    {
        // Hide the PetName property above me.
        public new string PetName { get; set; }

        // Hide any Draw() implementation above me.
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circle");
        }
    }

    // New Shape derived class named triangle
    class Triangle : Shape, IPointy
    {
        public Triangle() {}
        public Triangle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }

        // IPointy implememtation
        public byte Points { get { return 3; } }

    }
}
