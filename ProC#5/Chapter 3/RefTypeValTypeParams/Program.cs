using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeValTypeParams
{
    class Person
    {
        public string personName;
        public int personAge;

        // Constructors
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() {}

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Passing Person Object By Value ****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();

            SemdAPersonByValue(fred);
            Console.WriteLine("\nAfter call by value, Person is:");
            fred.Display();

            Console.ReadLine();
        }

        static void SemdAPersonByValue(Person p)
        {
            p.personAge = 18;

            p = new Person("John", 18);
        }
    }
}
