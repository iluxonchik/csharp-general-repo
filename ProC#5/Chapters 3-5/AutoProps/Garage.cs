using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Garage
    {
        // The hidden backing field is set to zero
        public int NumberOfCars { get; set; }

        // The hidden backing field is set to null
        public Car AnAuto { get; set; }
        // Must use constructors to override the default
        // values which are assigned to hidden backing values
        public Garage()
        {
            AnAuto = new Car();
            NumberOfCars = 1;
        }
        public Garage(Car car, int number)
        {
            AnAuto = car;
            NumberOfCars = number;
        }
    }
}
