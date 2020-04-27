using System;

namespace Calcs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3, r = 4;
            double y = 4.0;

            double d = (double)a / b; //Cast
            Console.WriteLine("d = {0}", d);

            double f = ((a + b) / (c - y)) - d;
            Console.WriteLine("f = {0}", f);

            double x1 = (-b + Math.Sqrt((b * b) - 4 * a * c)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);

            double A = Math.PI * r * r;
            Console.WriteLine("A = {0}", A);

            // Math.Sqrt(...) -> square root
            // Math.Pow(a, b) -> a^b
            // Math.PI -> 3.1415...
        }
    }
}
