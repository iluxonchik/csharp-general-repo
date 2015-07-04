using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    class Program
    {
        delegate void SomeDelegate();
        static void Main(string[] args)
        {

            Car c1 = new Car("car1", 100, 10);
            int cnt = 0;

            // Register event handlers as anonymous methods
            c1.AboutToBlow += delegate
            {
                Console.WriteLine("Bout to blow, brah!");
            };

            c1.AboutToBlow += delegate (object sender, CarEventArgs e)
            {
                cnt++;
                Console.WriteLine("Message from Car: {0}", e.msg);
            };

            c1.Exploded += delegate (object sender, CarEventArgs e)
            {
                Console.WriteLine("Fatal message from Car: {0}", e.msg);
            };

            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }

            // Unecessarily complex code
            SomeDelegate sd = delegate { Console.WriteLine("Called {0} times", cnt); };
            sd.Invoke();

            Console.ReadLine();
        }
    }
}
