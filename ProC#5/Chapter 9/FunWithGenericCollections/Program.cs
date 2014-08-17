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
            UseGenericStack();
            UseGenericQueue();

            Console.ReadLine();
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

        static void UseGenericStack()
        {
            Stack<Person> stackOfPeople = new Stack<Person>();
            stackOfPeople.Push(new Person {FirstName = "Frank", LastName = "Lampard" , Age = 22});
            stackOfPeople.Push(new Person {FirstName = "Didider", LastName = "Drogba" , Age = 21});
            stackOfPeople.Push(new Person {FirstName = "John", LastName = "Terry" , Age = 23});
            
            Console.WriteLine("First Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off: {0}", stackOfPeople.Pop());

            Console.WriteLine("\nFirst Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off: {0}", stackOfPeople.Pop());

            Console.WriteLine("\nFirst Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off: {0}", stackOfPeople.Pop());

            try 
            {
                Console.WriteLine("First Person is: {0}", stackOfPeople.Peek());
            Console.WriteLine("Popped off: {0}", stackOfPeople.Pop());
            }
            catch (InvalidOperationException ex){
                Console.WriteLine("\nError: {0}", ex.Message);
            }
        }

        static void GetCoffe(Person p)
        {
            Console.WriteLine("{0} got coffee!", p.FirstName);
        }

        static void UseGenericQueue()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person() { FirstName = "John", LastName = "Terry" });
            peopleQ.Enqueue(new Person() { FirstName = "Frank", LastName = "Lampard" });
            peopleQ.Enqueue(new Person() { FirstName = "Didier", LastName = "Drogba" });

            Console.WriteLine("{0} first in line!", peopleQ.Peek().FirstName);
        
            // Remove each person from Queue
            GetCoffe(peopleQ.Dequeue());
            GetCoffe(peopleQ.Dequeue());
            GetCoffe(peopleQ.Dequeue());
            // Try the Dequeue again?
            try
            {
                GetCoffe(peopleQ.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }
        }
    }
}
