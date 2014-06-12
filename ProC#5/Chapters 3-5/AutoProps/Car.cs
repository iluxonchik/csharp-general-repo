using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        // Automatic properties
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        // Constructors
        public Car(string name, int speed, string color)
        {
            this.PetName = name;
            this.Speed = speed;
            this.Color = color;
        }
        public Car() :this("Default Car PetName", 100, "Blue") { }

        public void DispayStats()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}
