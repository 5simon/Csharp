using System;

namespace EmployeeManagerLib
{
    public class Project
    {
        public string Name
        {
            get;
            private set;
        }

        private double budget;

        public Project(string newName, double newBudget)
        {
            Name = newName;
            budget = newBudget;
        }

        public override string ToString()
        {
            return string.Format("Project {0}", Name);
        }

        public override bool Equals(object obj)
        {
            return ((obj as Project)?.Name == Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        private bool CheckForProjectStaff(Employee employee)
        {
            ProjectStaff projectStaff = (employee as ProjectStaff);

            if (projectStaff == null)
            {
                return false;
            }

            return (projectStaff.MainProject == this);
        }

        private bool CheckForScientist(Employee employee)
        {
            Scientist scientist = (employee as Scientist);

            if (scientist == null)
            {
                return false;
            }

            return scientist.Projects.Contains(this);
        }

        public void WithdrawMoney(double amount, Employee employee)
        {
            //Check amount of money:
            if (budget < amount)
            {
                throw new UnauthorizedAccessException(string.Format("Not enough project money (needs {0}€, has {1}€)", amount, budget));
            }

            //Check employee:
            if (!CheckForProjectStaff(employee) && !CheckForScientist(employee))
            {
                throw new UnauthorizedAccessException("Employee is neither a project staff nor a scientist involved with the project.");
            }

            //Everything's okay. Withdraw the money.
            budget -= amount;
        }
    }
}
