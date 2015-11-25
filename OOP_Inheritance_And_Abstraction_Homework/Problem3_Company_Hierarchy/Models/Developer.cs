using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem3_Company_Hierarchy.Interfaces;

namespace Problem3_Company_Hierarchy
{
    class Developer:RegularEmployee,IDeveloper
    {

        public HashSet<Project> Projects { get; set; }
        public Developer(string id, string firstName, string lastName, decimal salary, string department,HashSet<Project>projects ) : base(id, firstName, lastName, salary, department)
        {
            this.Projects = new HashSet<Project>(projects);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine("Projects: ");
            foreach (var project in Projects)
            {
                result.AppendLine("\tProject name: " + project.ProjectName);
                result.AppendLine("\tProject start date: " + project.ProjectStartDate);
                result.AppendLine("\tProject state: " + project.State+"\n");
            }
            return result.ToString();
        }
    }
}
