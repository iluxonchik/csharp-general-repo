using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy ****\n");
            
            Manager chucky = new Manager("Cucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 300, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "123", 5);
            GivePromotion((Manager)frank); // explicit casting, yay!

            //A Manager "is-an" Employee too
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "567", 1);
            GivePromotion(moonUnit);

            // A PTSalesPerson "is-a" SalesPerson
            SalesPerson jill = new PTSalesPerson("Jill", 834, 30001, 123123, "123124", 90);
            GivePromotion(jill);

            // Use "as" to test compatability
            /* Hexagon hex2 = frank as Hexagon;
             * if (hex2 == null)
             *      Console.WriteLine("Sorry, frank is not a Hexagon...");
             */

            Console.ReadLine();
        
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);

            if (emp is SalesPerson)
            {
                Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    
    }
}
