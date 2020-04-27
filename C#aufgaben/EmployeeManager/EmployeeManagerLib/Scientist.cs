using System;
using System.Collections.Generic;

namespace EmployeeManagerLib
{
    public class Scientist : Employee, ITeach
    {
        public string Title
        {
            get;
            private set;
        }

        public List<Project> Projects
        {
            get;
            set;
        } = new List<Project>();

        public List<Course> Courses
        {
            get;
            set;
        } = new List<Course>();

        public override List<Project> AssociatedProjects => Projects;

    /*
        //More verbose version:
        public override List<Project> AssociatedProjects
        {
            get
            {
                return Projects;
            }
        }
    */

        public Scientist(string newFirstName, string newSurName, double newSalary, string newTitle)
            : base(newFirstName, newSurName, newSalary)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return string.Format("Scientist {0} {1}", FirstName, SurName);
        }

        public void Teaching()
        {
            foreach (Course c in Courses)
            {
                Console.WriteLine(c);
            }
        }
    }
}
