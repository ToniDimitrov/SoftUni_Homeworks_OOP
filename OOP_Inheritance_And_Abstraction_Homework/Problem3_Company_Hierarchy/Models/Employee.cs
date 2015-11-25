using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy
{
    abstract class Employee:Person,IEmployee
    {
        private decimal salary;
        private string department;
        public Employee(string id, string firstName, string lastName,decimal salary,string department) : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public string Department
        {
            get { return this.department; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The department name must be non-empty");
                }
                if (value.ToLower() != "production" && value.ToLower() != "accounting" && value.ToLower() != "sales" && value.ToLower() != "marketing")
                {
                    throw new ArgumentException("The department name is not valid (Valid choices: Production, Accounting, Sales, Marketing)");
                }
                this.department = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary must be non-negative");
                }
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Department: " + this.Department + "\n" + "Salary: " + this.Salary + "\n";
        }
    }
}
