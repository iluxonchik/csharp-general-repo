﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumerator
{
    public class Garage : IEnumerable
    {
        // System.Array already implements IEnumerator
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // Return the array object's IEnumerator
            return this.carArray.GetEnumerator();
        }
    }
}
