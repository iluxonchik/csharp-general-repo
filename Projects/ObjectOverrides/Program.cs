using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Fun With System.Object\n ***");
            // NOTE: Those gotta be indentical to test the
            // Equals() and GetHash() methods
            Person p1 = new Person("Jason", "Meow", 18);
            Person p2 = new Person("Jason", "Meow", 18);

            // Get stringified versions of objects
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());

            // Test the overridden Equals()
            Console.WriteLine("p1 = p2? : {0}", p1.Equals(p2));

            // Test hash codes
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());

            // Change the age of p2 and test again
            p2.Age = 19;

            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine("p1 = p2? : {0}", p1.Equals(p2));
            Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() == p2.GetHashCode());


            Console.ReadLine();
        }
    }
}
