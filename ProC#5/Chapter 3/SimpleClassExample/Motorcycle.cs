using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        
        public void PopAWheely()
        {
            for (int i = 0; i <= this.driverIntensity; i++)
                Console.WriteLine("Yahoooo!");
        }

        // Put back the default constuctor, which will
        // set all data members to default values
        public Motorcycle() { }

        // A custum constructor
        public Motorcycle(int intensity)
        {
            this.driverIntensity = intensity;
        }

        public void setDriverName(string driverName)
        {
            this.driverName = driverName; // this keyword necessary to resolve the ambiguity
        }
    }
}
