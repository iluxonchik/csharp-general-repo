using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    class Notifier
    {

        private int count;
        
        public int Count 
        {
            set
            {this.count = value;}

            get { return this.count; }
        }

        public delegate void Notify(string msg);

        private Notifier.Notify listOfClients;


        public Notifier(int countValue)
        {
            Count = countValue;
        }

        public void Test()
        {
            for (int i = 0; i < Count; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }

            if (listOfClients != null)
            {
                listOfClients( Count.ToString() + " seconds have passed!");
            }
        }

        public void RegisterAMethod(Notify methodToCall)
        {
            listOfClients += methodToCall;
        }

        public void UnregisterAMethod(Notify methodToCall)
        {
            listOfClients -= methodToCall;
        }
    }
}
