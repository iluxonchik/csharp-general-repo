using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public int Count
        {
            get
            {
                return arPeople.Count;
            }
        }
        // Custom indexer for this class
        public Person this[int index]
        {
            get
            {
                return (Person)arPeople[index];
            }
            set
            {
                arPeople.Insert(index, value);
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
