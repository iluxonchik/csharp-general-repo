using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Field data
        private string empName;
        private int empID;
        private float currPay;

        // Acessor (get method)
        public string GetName()
        {
            return this.empName;
        }

        // Mutator (set method)
        public void SetName(string name)
        {
            // Perform a check on the incoming
            // value before making the assignment
            if (name.Length > 15)
                Console.WriteLine("Error! Name must be 16 characters or less!");
            else
                this.empName = name;
        }
        // Constructor
        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            this.empName = name;
            this.empID = id;
            this.currPay = pay;
        }

        // Methods
        public void GiveBonus(float amount)
        {
            this.currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", this.empName);
            Console.WriteLine("ID: {0}", this.empID);
            Console.WriteLine("Pay: {0}", this.currPay);
        }
    }
}
