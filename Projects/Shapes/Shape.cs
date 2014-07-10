using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // The abstract base class of the hierarchy
    abstract class Shape
    {
        // Constructors
        public Shape(string name = "NoName")
        { PetName = name; }
        
        // Properties
        public string PetName { get; set; }

        // Methods

        // Force all child classes to define how to be rendered
        public abstract void Draw(); // NOTE: no default impletemnation whatsoever
    }
}
