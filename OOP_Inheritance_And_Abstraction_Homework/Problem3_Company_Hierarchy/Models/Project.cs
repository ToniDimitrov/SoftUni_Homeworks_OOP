using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy
{
    class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private string state;

        public Project(string projectName, DateTime projectStartDate, string state, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.State = state;
            this.Details = details;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The project name must be non-empty");
                }
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                if (value.Year <= 1980)
                {
                    throw new ArgumentOutOfRangeException("Invalid start date of the project");
                }
                this.projectStartDate = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The project details must be non-empty");
                }
                this.details = value;
            }
        }

        public string State
        {
            get { return this.state; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The project name must be non-empty");
                }
                if (value != "Open" && value != "Closed")
                {
                    throw new ArgumentException("The state of the project must be 'Open' or 'Closed'");
                }
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = "Closed";
        }

        public override string ToString()
        {
            return this.GetType().Name + "\n" + "Project name: " + this.ProjectName + "\n" + "Project start date: " +
                   this.ProjectStartDate + "\n" + "Project details: " + this.Details + "\n" + "Project state: " +
                   this.State + "\n";
        }
    }
}
