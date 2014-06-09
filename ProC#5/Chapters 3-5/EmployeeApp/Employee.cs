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
        private string empSS;

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

        public string SSN
        {
            // There is no 'set' method. This property is Read-Only
            get
            {return this.empSS;}
        }

        // The 'int' represents the type of data this proprety encapsulates
        // The data type must be identical to the related field (this.empID)
        public int ID
        {
            get { return this.empID; }
            set { this.empID = value; }
        }
        public float Pay
        {
            get { return this.currPay; }
            set { this.currPay = value; }
        }



        // Constructors
        public Employee() { }

        public Employee(string name, int id, float pay, string ssn)
            : this(name, 0, id, pay, "1234") { } // if 'age' is skipped, it's set to 0
            // if ssn is skipped it gets set to "1234"
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            Age = age;
            ID = id;
            Pay = pay;
            this.empSS = ssn; // SSN = ssn; would not work, the property is Read-Only!
        }

        // Methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("ID: {0}", this.ID);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("Pay: {0}", this.Pay);
        }
    }
}
