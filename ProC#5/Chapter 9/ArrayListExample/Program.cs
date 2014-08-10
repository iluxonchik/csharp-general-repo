using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            Console.WriteLine("{0} items\n", strArray.Count);

            // Add a new item and display the count
            strArray.Add("Fourth!");
            Console.WriteLine("Now there are {0} items! \n", strArray.Count);

            foreach(string s in strArray)
                Console.WriteLine("Entry: {0}", s);

            Console.ReadLine();
        }

      
    }
}
