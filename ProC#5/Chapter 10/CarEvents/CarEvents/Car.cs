using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
    {
        // This delegate works in conjuction with the Car's events
        public delegate void CarEngineHandler(string msg);

        // This car can send these events
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        
        public void Accelerate(int delta)
        {
            // If the car is "dead", send a dead message
            if (carIsDead)
            {
                if (Exploded != null)
                {
                    Exploded("Sorry, the car is dead...");
                }
            }
            else
                {
                    CurrentSpeed += delta;

                    // Is the car "almost dead"?
                    if (10 == (MaxSpeed - CurrentSpeed) && AboutToBlow != null)
                    {
                        AboutToBlow("Careful, it's gonna blow up!");
                    }
                }

                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            
        }


        // Internal state data
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the car alive?
        private bool carIsDead;

        // Class constructors
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
    }
}
