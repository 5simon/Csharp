using System;

namespace Errors
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;
            celsius = 0;
            fahrenheit = ((9f / 5) * celsius) + 32;
            Console.WriteLine("{0} Celsius entspricht {1} Fahrenheit", celsius, fahrenheit);
            Console.Write("Celsius: ");

            try
            {
                celsius = float.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong number format!");
                return;
            }

            fahrenheit = ((9f / 5) * celsius) + 32;
            Console.WriteLine("Fahrenheit: {0}", fahrenheit);

        }
    }
}
