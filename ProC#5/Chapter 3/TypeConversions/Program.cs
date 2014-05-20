using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Type Conversions ****");
           
            // Add two shorts and print the result
            short numb1 = 9, numb2 = 10;
            Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1,numb2));

            short numb3 = 30000, numb4 = 30000;

            // Explicitly cast an int into a short (and allow loss of data)
            short answer = (short)Add(numb3, numb4);

            Console.WriteLine("{0} + {1} = {2}", numb3, numb4, answer);

            NarrowingAttempt();

            Console.ReadLine();

        }

        static int Add(int x, int y)
        {
            // The compiler won't complain if shorts are provided as arguments,
            // because a short fits in an int for sure (implicit upward cast)
            return x + y;
        }

        static void NarrowingAttempt()
        {
            byte aByte = 0;
            int anInt = 200;

            // Explicitly cast an into into a byte (no loss of data)
            aByte = (byte)anInt;
            Console.WriteLine("Value of aByte: {0}", aByte);
        }
    }
}
