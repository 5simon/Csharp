using System;
using System.Collections.Generic;

namespace EmployeeManagerLib
{
    public class Assistant : Employee
    {
        public int HoursPerWeek
        {
            get;
            private set;
        }

        public Project WorkProject
        {
            get;
            private set;
        }

        public override List<Project> AssociatedProjects
        {
            get
            {
                var list = new List<Project>();

                if (WorkProject != null)
                {
                    list.Add(WorkProject);
                }

                return list;
            }
        }

        public Assistant(string newFirstName, string newSurName, double newSalary, int newHoursPerWeek, Project newWorkProject = null)
            : base(newFirstName, newSurName, newSalary)
        {
            HoursPerWeek = newHoursPerWeek;
            WorkProject = newWorkProject;
        }

        public override string ToString()
        {
            return string.Format("Assistant {0} {1}", FirstName, SurName);
        }
    }
}
