using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy ****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 18;
            fred.Name = "Fred";
            fred.SalesNumber = 999;
        }
    }
}
