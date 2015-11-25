using System;

namespace Problem1_Human_Student_Worker
{
    internal class Worker : Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day must be non-negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The week salary must be non-negative");
                }
                this.weekSalary = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return (WeekSalary/5.00m)/(decimal) WorkHoursPerDay;
        }

        public override string ToString()
        {
            return "First Name: " + this.FirstName + "\n" + "Last Name: " + this.LastName + "\n" +
                   string.Format("Payment per hour: {0:C}",this.MoneyPerHour()) + "\n";
        }
    }
}
