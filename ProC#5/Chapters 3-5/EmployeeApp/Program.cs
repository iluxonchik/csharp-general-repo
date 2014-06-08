using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Encapsulation ****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();

            // Set and get the name proprety
            // It appears to the caller that it is getting and setting a public
            // point of data; however, the correct get and set block is called 
            // behind the scenes to preserve encapsulation
            emp.Name = "Marv"; // 'Name' is the name of the property
            Console.WriteLine("Employee is named: {0}", emp.Name);

            Console.ReadLine();
        }
    }
}
