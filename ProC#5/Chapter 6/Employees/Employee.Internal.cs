using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   partial class Employee
    {
        // Derived classes can now directly acess this information
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

       // Constructors
       public Employee() { }

        public Employee(string name, int id, float pay, string ssn)
            : this(name, 0, id, pay, "1234") { } // if 'age' is skipped, it's set to 0
        // if ssn is skipped it gets set to "1234"
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            this.empName = name;
            this.empAge = age;
            this.empID = id;
            this.currPay = pay;
            this.empSSN = ssn;
        }

    }
}
