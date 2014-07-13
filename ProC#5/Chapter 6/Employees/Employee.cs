using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // Employee class in now abstact, i.e. cannot be directly instantiated
    // (ex: Employee X = new Employee(); is now illegal!)
    abstract partial class Employee
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

        static void CastingExamples()
        {
            // Manager "is-a" System.Object, so we can
            // store a manager reference in an onject variable
            object frank = new Manager("Frank", 9, 300, 40000, "111-11-111", 5);

            // A Manager "is-an" Employee too
            Employee moonUnit = new Manager("MoonUnit", 2, 3001, 2000, "111-11-1234", 1);

            // A PTSalesPerson "is-a" SalesPerson
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 10000, "1231", 90);
        }
    }
}
