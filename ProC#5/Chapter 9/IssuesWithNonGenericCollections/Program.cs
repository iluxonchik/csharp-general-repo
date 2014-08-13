using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IssuesWithNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void SimpleUnboxOperation()
        {
            // Make a ValueType (int) variable
            int myInt = 25;

            // Box the int into an object reference
            object boxedInt = myInt;

            // Unbox the reference back into a corresponding int
            int unboxedInt = (int)boxedInt;

            // Unbox into the wrong data type to trigger a runtime exception
            try 
            {
                long unboxedInt2 = (long)boxedInt;
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void UseGenericList()
        {
            Console.WriteLine("***** Fun With Generics *****\n");

            // This List<> can only hold Person objects
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person());

            // This List<> can only hold integers
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];

            // moreInts.Add(new Person()) would cause a compile error

        }
    }

    public class Person
    {
        // For demo puroposes
    }
}
