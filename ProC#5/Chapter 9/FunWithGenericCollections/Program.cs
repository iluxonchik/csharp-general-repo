using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void UseGenericList()
        {
            // Make a List of Person objects, filled with
            // collection/object init syntax
            List<Person> people = new List<Person>()
            {
                new Person {FirstName = "John", LastName="Terry", Age= 30},
                new Person {FirstName = "Frank", LastName = "Lampard", Age= 18},
                new Person {FirstName = "Petr", LastName = "Cech", Age= 19}
            };

            // Print the number of items in the list
            Console.WriteLine("Items in the list: {0}", people.Count);

            // Enumerate over the list
            foreach (Person p in people)
                Console.WriteLine(p);

            // Insert a new Person
            Console.WriteLine("\n-> Inserting a new person...");
            people.Insert(2, new Person { FirstName = "Fernando", LastName = "Torres", Age = 20 } );
            Console.WriteLine("Items in list: {0}", people.Count);

            // Copy data into a new array
            Person[] arrOfPeople = people.ToArray();
            for (int i = 0; i < arrOfPeople.Length; i++)
                Console.WriteLine("First Name: {0}", arrOfPeople[i].FirstName);
        }
    }
}
