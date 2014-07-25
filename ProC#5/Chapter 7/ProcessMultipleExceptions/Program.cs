using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car aCar = new Car("Rusty", 90);
            try
            {
                aCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                  Console.WriteLine(e.Message);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

            }

        }
    }
}
