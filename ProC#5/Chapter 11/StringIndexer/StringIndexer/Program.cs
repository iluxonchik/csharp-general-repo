using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCollection people = new PersonCollection();
            people["Jason"] = new Person("Jason");
            people["Jane"] = new Person("Jane");

            Person jason = people["Jason"];
            Console.WriteLine(jason.Name);
        }
    }
}
