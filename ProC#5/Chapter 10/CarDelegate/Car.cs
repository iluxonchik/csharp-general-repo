using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    public class Car
    {

        // 1) Define a delegate type
        public delegate void CarEngineHandler(string msgForCaller);

        // 2) Define a member variable of this delegate
        private CarEngineHandler listOfHandlers;

        // 3) Add a registration function for the caller
        // Now with multicasting support
        // The += operator is used instead of the assignment operator (=)
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers += methodToCall;
        }

        // 4) Implemenet the Accelerate() method to invoke the delegate's
        //    invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            // If the car is "dead", send a dead message
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers("Sorry, the car is dead...");
                }
            }
            else
                {
                    CurrentSpeed += delta;

                    // Is the car "almost dead"?
                    if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                    {
                        listOfHandlers("Careful, it's gonna blow up!");
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
