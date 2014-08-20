﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a collection to observe and add a few Person objects
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person {FirstName = "Jonh", LastName = "Terry"},
                new Person {FirstName = "Adam", LastName = "Terry"},
            };

            // Wire up the CollectionChanged event
            people.CollectionChanged += people_CollectionChanged;
        }

        static void people_CollectionChanged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // What was the action that caused the event?
            Console.WriteLine("Action for this event: {0}", e.Action);

            // Something was removed
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items: ");
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();

                // Something was added
                if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
                {
                    Console.WriteLine("Here are the NEW items: ");
                    foreach (Person p in e.NewItems)
                    {
                        Console.WriteLine(p.ToString());
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
