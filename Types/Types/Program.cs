using System;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string description;
            int regId;
            char category;
            double luminosity;

            //Input:
            try
            {
                Console.Write("Please enter description -> ");
                description = Console.ReadLine();

                Console.Write("Please enter reg ID -> ");
                regId = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ausnahme!");
                return;
            }

            //Output:
            Console.WriteLine("Description: {0}", description);
            Console.WriteLine("RegId: {0:D5}", regId);
            //Console.WriteLine("Category: {0}", category);
            //Console.WriteLine("Luminosity: {0:F2}", luminosity);
        }
    }
}
