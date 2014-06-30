using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {

        // Propreties!    
        // Methods
        public void GiveBonus(float amount)
        {
            this.currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", this.empName);
            Console.WriteLine("ID: {0}", this.empID);
            Console.WriteLine("Age: {0}", this.empAge);
            Console.WriteLine("Pay: {0}", this.currPay);
        }
    }
}
