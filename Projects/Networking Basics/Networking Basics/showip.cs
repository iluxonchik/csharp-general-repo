using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Networking_Basics
{
    class ShowIP
    {
        public void showIP(string machineName = null)
        {
            string name = (machineName != null) ? machineName : Dns.GetHostName();
            try
            {
                IPAddress[] addrs = Dns.GetHostEntry(name).AddressList;
                Console.WriteLine("Dns.GetHostEntry: {0}", Dns.GetHostEntry(name));
                Console.WriteLine("AddressList: {0}", Dns.GetHostEntry(name).AddressList);
                foreach (IPAddress addr in addrs)
                {
                    Console.WriteLine("{0} / {1} Addr Family: {2}", name, addr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
