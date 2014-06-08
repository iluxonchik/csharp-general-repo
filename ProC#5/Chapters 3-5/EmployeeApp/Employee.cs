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
        private int empAge;

        // Propreties!

        public int Age
        {
            get { return this.empAge; }
            set { this.empAge = value; }
        }
        public string Name
        {
            get { return this.empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name must be 16 chars or less");
                else
                    this.empName = value;
            }
        }

        // The 'int' represents the type of data this proprety encapsulates
        // The data type must be identical to the related field (this.empID)
        public int ID
        {
            get { return this.empID; }
            set { this.empID = value; }
        }
        public float pay
        {
            get { return this.currPay; }
            set { this.currPay = value; }
        }



        // Constructor
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { } // if 'age' is skipped, it's set to 0
        public Employee(string name, int age, int id, float pay)
        {
            this.empName = name;
            this.empID = id;
            this.currPay = pay;
            this.empAge = age;
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
            Console.WriteLine("Age: {0}", this.empAge);
            Console.WriteLine("Pay: {0}", this.currPay);
        }
    }
}
