using System;
using System.IO;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //"c" is an instance / object of type "Computer".
            Computer c;

            //Call constructor of class "Computer" to initialize it.
            c = new Computer();

            //In one line:
            //Computer c = new Computer();

            //Call "PrintHelloWorld()" method (static -> called via class):
            Computer.PrintHelloWorld();

            Console.WriteLine("User that is currently logged in: {0}", c.UserName);

            //Perform a user change:
            c.ChangeUser("jonas");

            Console.WriteLine("User that is now logged in: {0}", c.UserName);

            /*
            //Save a file:
            // '\' is an escape character

            while (true)
            {
                try
                {
                    c.SaveFile("Dissertation.tex");
                }
                catch (InvalidOperationException ex) //"ex" is the caught exception ...
                {
                    Console.WriteLine("Computer has crashed :(");
                    Console.WriteLine("Details: {0}", ex.Message);

                    c.Reboot();
                }
            }
            */

            //IP addresses:
            Console.WriteLine(c.IPAddress);
            c.IPAddress = "0011:2233:4455:6677:8899:aabb:ccdd:eeff";
            Console.WriteLine(c.IPAddress);

            //DVDs:
            DVD dvd;
            c.BurnDVD("Star Wars", "pew pew", out dvd);
            dvd.Print();

            //Computer pools:
            c.Print();

            //Initialize the pool:
            Computer[] pool = new Computer[100];

            for (int i = 0; i < pool.Length; i++)
            {
                pool[i] = new Computer();
            }

            //Save files and count crashes:
            int crashCount = 0;

            //TODO:
            // - Iterate through all computers via "foreach" loop
            // - Try to save a file on each computer
            // - Count the crashes (=> try-catch necessary)

            foreach (Computer comp in pool)
            {
                try
                {
                    comp.SaveFile("Dissertation.tex");
                }
                catch
                {
                    crashCount++;
                    Console.WriteLine("Crash");
                }
            }

            Console.WriteLine("Number of crashed computers: {0}", crashCount);
        }
    }
}
