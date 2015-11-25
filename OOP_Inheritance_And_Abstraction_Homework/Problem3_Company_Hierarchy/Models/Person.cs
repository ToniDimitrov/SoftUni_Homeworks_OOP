using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy
{
    abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The last name must be non-empty");
                }
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The first name must be non-empty");
                }
                this.firstName = value;
            }
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The ID must be non-empty");
                }
                this.id = value;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + "\n" + "First Name: " + this.FirstName + "\n" + "Last Name: " + this.LastName +
                   "\n" + "ID: " + this.Id + "\n";
        }
    }
}
