using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = -1;

            do
            {
                //Get the year:
                Console.Write("Year -> ");

                try
                {
                    year = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad format!");
                    continue;
                }

                if (year != 0)
                {
                    //Test if it is a leap year:
                    bool isLeapYear = ((year % 400) == 0) || (((year % 4) == 0) && ((year % 100) != 0));

                    //Output:
                    if (isLeapYear)
                    {
                        Console.WriteLine("{0} is a leap year.", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a leap year.", year);
                    }
                }
            } while (year != 0);
        }
    }
}
