using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standart, Gold, Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }

        Employee.BenefitPackage empBenefits = new Employee.BenefitPackage();

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
        // This method can now be "overriden" by a derived class
        public virtual void GiveBonus(float amount)
        {
            this.currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", this.empName);
            Console.WriteLine("ID: {0}", this.empID);
            Console.WriteLine("Age: {0}", this.empAge);
            Console.WriteLine("Pay: {0}", this.currPay);
        }
    }
}
