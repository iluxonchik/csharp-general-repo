using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Networking_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIP sip = new ShowIP();
            sip.showIP();
            Console.ReadLine();
        }
    }
}
