using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLConnectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=.;Database=Test;Trusted_Connection=True");
            try
            {
                conn.Open();
                Console.WriteLine("Connection Successful!");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! {0}", e.Message);
                Console.ReadLine();
            }

        }
    }
}

