using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call to turn the radio on/off is done internally
            Car aCar = new Car();
            aCar.TurnOnRadio(false);
        }
    }
}
