using System;
using System.Collections.Generic;

namespace EmployeeManagerLib
{
    public class ExternalLecturer : Employee, ITeach
    {
        public List<Course> Courses
        {
            get;
            set;
        } = new List<Course>(); //Could also be done in the constructor ...

        public ExternalLecturer(string newFirstName, string newSurName, double newSalary)
            : base(newFirstName, newSurName, newSalary)
        {

        }

        public override string ToString()
        {
            return string.Format("External lecturer {0} {1}", FirstName, SurName);
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
