using System;
using System.Collections.Generic;

namespace EmployeeManagerLib
{
    public abstract class Employee
    {
        private static int nextId = 0;

        public string FirstName
        {
            get;
            private set;
        }

        public string SurName
        {
            get;
            private set;
        }

        public int Id
        {
            get;
            private set;
        }

        public double Salary
        {
            get;
            private set;
        }

        public virtual List<Project> AssociatedProjects
        {
            get
            {
                return new List<Project>();
            }
        }

        public Employee(string newFirstName, string newSurName, double newSalary)
        {
            FirstName = newFirstName;
            SurName = newSurName;
            Id = nextId++;
            Salary = newSalary;
        }

        public override string ToString()
        {
            return string.Format("Employee {0} {1}", FirstName, SurName);
        }

        public override bool Equals(object obj)
        {
            return ((obj as Employee)?.Id == Id);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
