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

        // Constructor chaining
        public Motorcycle() { }
        public Motorcycle(int intensity) : this(intensity, "") { }
        public Motorcycle(string name)
            : this(0, name){ }

        // This is the 'master' constructor that does all the real work
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
                intensity = 10;
            this.driverIntensity = intensity;
            this.driverName = name;
        }

        public void setDriverName(string driverName)
        {
            this.driverName = driverName; // this keyword necessary to resolve the ambiguity
        }
    }
}
