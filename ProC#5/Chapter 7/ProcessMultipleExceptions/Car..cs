﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Car
    {
        // Constant for maximum speed
        public const int MaxSpeed = 100;

        // Car properties
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        // Is the car operational?
        private bool carIsDead;

        // A car has-a radio
        private Radio theMusicBox = new Radio();

        // Constructors
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            // Delegate request to inner object
            theMusicBox.TurnOn(state);
        }

        // See if Car has overheadred
       public void Accelerate (int delta)
       {
           // test for invalid argumnet before proceeding
           if (delta < 0)
           {
               throw new
               ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
           }

           if (carIsDead)
               Console.WriteLine("{0} is out of order...", PetName);
           else
           {
               CurrentSpeed += delta;
               if (CurrentSpeed > MaxSpeed)
               {
                   CurrentSpeed = 0;
                   carIsDead = true;

                  // We need to call the HelpLink property,  thus we need
                  // to create a local variable before throwing the Exception object
                   CarIsDeadException ex = new CarIsDeadException(string.Format("{0} has overheated!", PetName), "You have a lead foot", DateTime.Now);
                   ex.HelpLink = "http://www.google.co.uk";
                   throw ex;

               }
               else
                   Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
           }
       }

    }
}
