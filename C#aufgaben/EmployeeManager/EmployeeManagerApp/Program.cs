using System;
using System.Collections.Generic;
using EmployeeManagerLib;

namespace EmployeeManagerApp
{
    class Program
    {
        // Project -> List<Employee>
        static Dictionary<Project, List<Employee>> GetProjectEmployees(List<Employee> employees)
        {
            var dict = new Dictionary<Project, List<Employee>>();

            foreach (Employee e in employees)
            {
                foreach (Project p in e.AssociatedProjects)
                {
                    List<Employee> tmpEmployees;

                    //Test if the key (= the project) already exists in the dictionary.
                    //If it does, we retrieve the existing list and add the current employee.
                    //Otherwise, we insert the project and associate it with a one-element list.
                    if (dict.TryGetValue(p, out tmpEmployees))
                    {
                        tmpEmployees.Add(e);
                    }
                    else
                    {
                        tmpEmployees = new List<Employee>
                        {
                            e
                        };

                        dict.Add(p, tmpEmployees);
                    }
                }
            }

            return dict;
        }

        static void Main(string[] args)
        {
            //Example for dictionary:
            Project p0 = new Project("C#", 100000);
            Project p1 = new Project("Bitcoins", 5000000);
            var s0 = new Scientist("Vera", "Musterfrau", 60000, "Dr");

            s0.Projects.Add(p0);
            s0.Projects.Add(p1);

            var projectEmployees = new List<Employee>
            {
                new ExternalLecturer("Peter", "Müller", 40000),
                new Assistant("Hans", "Hansen", 30000, 40, p0),
                s0
            };

            var dict = GetProjectEmployees(projectEmployees);

            //Print those employees working on project "C#":
            var cSharpEmployees = dict[p0];

            Console.WriteLine("Employees on the C# project:");

            foreach (Employee e in cSharpEmployees)
            {
                Console.WriteLine(e);
            }

            //Example for withdrawing money:
            Project testProject = new Project("C#", 100000);
            ProjectStaff a = new ProjectStaff("Fritz", "Müller", 20000, testProject);
            testProject.WithdrawMoney(10000, a);

            //Example for ITeach interface:
            List<ITeach> teachers = new List<ITeach>
            {
                new Scientist("Hans", "Petersen", 40000, "Dr"),
                new ExternalLecturer("Günther", "Hansen", 30000)
            };

            foreach (ITeach teacher in teachers)
            {
                teacher.Teaching(); //Polymorphism
            }
        }
    }
}
