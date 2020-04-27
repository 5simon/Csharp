using System;

namespace Lesson6
{
    class DVD
    {
        //ID of the next DVD we create:
        private static int nextID = 0;

        public int ID
        {
            get;
            private set;
        }

        public string Label
        {
            get;
            private set;
        }

        public string Content
        {
            get;
            private set;
        }

        public void Print()
        {
            Console.WriteLine("\"{0}\" [{1}]: \"{2}\"", Label, ID, Content);
        }

        public DVD(string newLabel, string newContent)
        {
            ID = nextID++;
            Label = newLabel;
            Content = newContent;

            //nextID += 1;
        }
    }
}
