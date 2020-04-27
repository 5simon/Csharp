using System;
using System.Collections.Generic;

namespace EmployeeManagerLib
{
    public class ProjectStaff : Employee
    {
        private Project mainProject;

        public Project MainProject
        {
            get
            {
                return mainProject;
            }

            set
            {
                mainProject = value ?? throw new NullReferenceException("Project staff needs valid main project.");

                /*
                    //More verbose version:
                    if (value == null)
                    {
                        throw new NullReferenceException("Project staff needs valid main project.");
                    }

                    mainProject = value;
                */
            }
        }

        public override List<Project> AssociatedProjects => new List<Project>
                                                            {
                                                                mainProject
                                                            };

        public ProjectStaff(string newFirstName, string newSurName, double newSalary, Project newMainProject)
            : base(newFirstName, newSurName, newSalary)
        {
            MainProject = newMainProject;
        }

        public override string ToString()
        {
            return string.Format("Project staff {0} {1}", FirstName, SurName);
        }
    }
}
