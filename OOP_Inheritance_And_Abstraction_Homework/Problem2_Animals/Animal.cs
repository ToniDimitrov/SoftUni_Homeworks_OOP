using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Animals
{
    internal abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name must be non-empty");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The age must be non-negative");
                }
                age = value;
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("The gender must be female or male");
                }
                gender = value;
            }
        }

        public abstract void ProduceSound();

        public Animal this[int i]
        {
            get { return this[i]; }
            set { this[i] = value; }
        }
        public override string ToString()
        {
            return this.GetType().Name+":\n" + "Name: " + this.Name + "\n" + "Age: " + this.Age + "\n" + "Gender: " + this.Gender + "\n";
        }
    }
}
