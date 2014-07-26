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
                // Trigger an argument out of range exception
                aCar.Accelerate(-10);
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
                // rethrow the exception up the stack to the previous caller
                // NOTE: in this example code, the ultimate receiver of CarIsDeadException is the CLR, because
                // it is the Main() method rethrowing the exception.
                throw;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                // This will catch any other exceprion
                // beyond CarIsDeadException or
                // ArgumentOutOfRangeException
                Console.WriteLine(e.Message);
            }

            // General exception example
            try
            {
                aCar.Accelerate(-100);
            }
            catch
            {
                Console.WriteLine("Something went wrong...");
            }

            Console.ReadLine();

            }

        }
    }

