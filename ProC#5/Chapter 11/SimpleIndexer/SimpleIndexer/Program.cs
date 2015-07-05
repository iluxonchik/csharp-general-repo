using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection people = new PersonCollection();

            // Add objects with indexer syntax
            people[0] = new Person() { Name = "Jason" };
            people[1] = new Person() { Name = "Jane" };
            people[2] = new Person() { Name = "Robert" };
            people[3] = new Person() { Name = "Katie" };

            for (int i = 0; i < people.Count; i++)
                Console.WriteLine(people[i].Name);
        }
    }
}
