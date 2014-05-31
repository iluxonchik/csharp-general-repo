using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car
        public string petName;
        public int currSpeed;

        // The functionality of the Car
        public void PrintState()
        {
            Console.WriteLine("{0} is going at {1} km/h", petName, currSpeed);
        }
        public void SpeedUp(int delta)
        {
            this.currSpeed += delta;
        }

        // A custom default constructor
        public Car()
        {
            this.petName = "Rawings";
            this.currSpeed = 25;
        }

        // Here, currSpeed will recieve the
        // default value of an int (zero)
        public Car(string pn)
        {
            this.petName = pn;
        }
        // Let the caller set the full state of the car
        public Car (int s, string pn)
        {
            this.currSpeed = s;
            this.petName = pn;
        }
    }
}
