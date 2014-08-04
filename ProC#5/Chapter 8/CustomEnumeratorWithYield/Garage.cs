using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    public class Garage : IEnumerator
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

        public IEnumerator GetEnumerator()
        {
            foreach (Car c in carArray)
            {
                yield return c;
            }
        }

        public IEnumerable GetTheCars(bool ReturnReversed)
        {
            // Return the items in reverse
            if (ReturnReversed)
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else
            {
                // Return items as placed in the array
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }
        }
    }
}
