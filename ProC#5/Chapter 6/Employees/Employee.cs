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
