using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   partial class Employee
    {
        // Field data
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        private string empSS;

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

    }
}
