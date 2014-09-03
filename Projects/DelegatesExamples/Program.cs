using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // This here is to be able to add non-static methods to the list of clients
            Program p1 = new Program(); 


            Notifier n1 = new Notifier(2);
            
            // Create some delegate objects
            Notifier.Notify delegate1 = new Notifier.Notify(p1.Method1);
            Notifier.Notify delegate2 = new Notifier.Notify(p1.Method2);
            Notifier.Notify delegate3 = new Notifier.Notify(p1.Method3);

            n1.RegisterAMethod(delegate1);
            n1.RegisterAMethod(delegate2);
            n1.RegisterAMethod(delegate3);

            n1.Test();

            // "Method2" removed from the list of clients
            // it will not report back anymore.
            n1.UnregisterAMethod(delegate2);

            n1.Test();

            Console.ReadLine();

        }


        // Just some methods to register/unregister
        public void Method1(string msg)
        {
            Console.WriteLine("\n Method1: {0}", msg);
        }

        public void Method2(string msg)
        {
            Console.WriteLine("\n Method2: {0}", msg);
        }

        public void Method3(string msg)
        {
            Console.WriteLine("\n Method3: {0}", msg);
        }
    }
}
