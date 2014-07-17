using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    // Person extends Object
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }

        // Return a hash code based on a point unique string data
        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() {}

        // Overring System.Object.ToString()
        public override string ToString()
        {
            string state;
            state = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}", FirstName, LastName, Age);
            return state;
        }

        // Overriding System.Obejct.Equals()
        public override bool Equals(object obj)
        {
            // No need to cast "obj" to a Person,
            // since EVERYTHING HAS A ToString() method
            return obj.ToString() == this.ToString();
        }

    }
}
