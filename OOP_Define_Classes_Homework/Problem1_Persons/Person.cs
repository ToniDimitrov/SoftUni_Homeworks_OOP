using System;

namespace Problem1_Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)  : this(name,age,null)
        {   
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("The age is less than 1!");
                }
                else if (value > 100)
                {
                    throw new Exception("The age is bigger than 100!");
                }
                age = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("The name is empty!");
                }
                name = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (value == null)
                {
                    this.email = null;
                }
                else if (!value.Contains("@"))
                {
                    throw new Exception("The email is not valid!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            if (Email == null)
            {
                return String.Format("Hi, my name is {0} and I am {1} years old.",this.Name,this.Age);
            }
            return String.Format("Hi, my name is {0} and I am {1} years old. My email is {2}",this.Name,this.Age,this.Email);
        }
    }
}
