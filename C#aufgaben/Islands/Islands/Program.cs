using System;

namespace Lesson5
{
    class Islands
    {
        static void Main()
        {
            //Which years are taken into account?
            int firstYear = 2005;
            int numberOfYears = 10;

            //Create a random number generator:
            Random rand = new Random();

            //Initialize the two arrays with random values:
            double[] firstIsland = new double[numberOfYears];
            double[] secondIsland = new double[numberOfYears];

            for (int i = 0; i < numberOfYears; i++)
            {
                firstIsland[i] = (90 * rand.NextDouble()) + 10;
                secondIsland[i] = (90 * rand.NextDouble()) + 10;
            }

            //Compare both arrays and calculate the sums:
            double sumA = 0, sumB = 0;

            for (int i = 0; i < numberOfYears; i++)
            {
                //Get the current values:
                double valA = firstIsland[i];
                double valB = secondIsland[i];

                Console.Write("Year {0}: ", firstYear + i);

                if (valA > valB)
                {
                    Console.WriteLine("A has higher emissions: {0:F2} tons", valA);
                }
                else if (valA < valB)
                {
                    Console.WriteLine("B has higher emissions: {0:F2} tons", valB);
                }
                else
                {
                    Console.WriteLine("Emissions are equal: {0:F2} tons", valA);
                }

                //Summate:
                sumA += valA;
                sumB += valB;
            }

            //Calculate the averages:
            double avgA = sumA / numberOfYears;
            double avgB = sumB / numberOfYears;

            Console.WriteLine("Average emissions for A: {0:F2} tons / year", avgA);
            Console.WriteLine("Average emissions for B: {0:F2} tons / year", avgB);

            if (avgA > avgB)
            {
                Console.WriteLine("A has higher average emissions.");
            }
            else if (avgA < avgB)
            {
                Console.WriteLine("B has higher average emissions.");
            }
            else
            {
                Console.WriteLine("Average emissions are equal.");
            }
        }
    }
}
