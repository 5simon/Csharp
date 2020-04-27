using System;

namespace EmployeeManagerLib
{
    public class Course
    {
        //Type declaration (could be placed outside of the class, too ...)
        public enum CourseType
        {
            Lecture,
            Tutorial,
            Seminar,
            Laboratory
        }

        //Actual property of that type:
        public CourseType Type
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }

        public Course(CourseType newType, string newName)
        {
            Type = newType;
            Name = newName;
        }

        public override bool Equals(object obj)
        {
            return ((obj as Course)?.Name == Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
