using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexer
{
    class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> people = new Dictionary<string, Person>();

        public Person this[string name]
        {
            get { return people[name]; }
            set { people[name] = value; }
        }

        public void ClearPeople() { people.Clear(); }

        public int Count { get { return people.Count; } }

        public IEnumerator GetEnumerator()
        {
            return people.GetEnumerator();
        }
    }
}
