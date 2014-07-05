using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {

        // Contain a benefit package
        protected BenefitPackage empBenefits = new BenefitPackage();

        // Expose certain benefit behaviors of object
        public double GetBenefitCost()
        { return empBenefits.ComputePayDeduction(); }

        // Expose object through a custom property
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
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
