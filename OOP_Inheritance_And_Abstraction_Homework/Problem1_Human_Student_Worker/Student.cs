using System;
using System.Text.RegularExpressions;

namespace Problem1_Human_Student_Worker
{
    internal class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                Regex regex = new Regex("\\b[\\dA-Za-z]{5,10}\\b");
                if (regex.IsMatch(value))
                {
                    this.facultyNumber = value;
                }
                else
                    throw new ArgumentException(
                        "The faculty number length must be from 5 to 10 charachters (digit\\letter)");
            }
        }

        public override string ToString()
        {
            return "First Name: " + this.FirstName + "\n" + "Last Name: " + this.LastName + "\n" +
                   "Faculty Number: " + this.FacultyNumber + "\n";
        }
    }
}
