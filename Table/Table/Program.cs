using System;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read values:
            double start, end, step;

            do
            {
                Console.Write("start -> ");
            } while (!double.TryParse(Console.ReadLine(), out start));

            do
            {
                Console.Write("end -> ");
            } while (!double.TryParse(Console.ReadLine(), out end));

            do
            {
                Console.Write("step -> ");
            } while (!double.TryParse(Console.ReadLine(), out step));

            //Iterate the interval:
            Console.WriteLine("x     ||     y");
            Console.WriteLine("==============");

            //Get an epsilon:
            double epsilon = 1e-15;

            for (double x = start; x <= end; x += step) //Kopfgesteuerte Schleife
            {
                //Calculate and print next value:
                double denom = Math.Pow(x - 1, 2) * (x + 2);

                if (Math.Abs(denom) <= epsilon)
                {
                    Console.WriteLine("{0:F3} || singularity", x);
                }
                else
                {
                    double y = ((3 * x) - 6) / denom;
                    Console.WriteLine("{0:F3} || {1:F3}", x, y);
                }
            }
        }
    }
}
