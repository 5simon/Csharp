using System;

namespace Cinderella
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize counters:
            double hazelVolume = 0;
            int hazelCount = 0;

            double walVolume = 0;
            int walCount = 0;

            //Read diameters:
            double diameter;

            do
            {
                //Read diameter:
                do
                {
                    Console.Write("Diameter [cm] -> ");
                } while (!double.TryParse(Console.ReadLine(), out diameter));

                if (diameter > 0)
                {
                    //Calculate the volume:
                    double volume = Math.PI * Math.Pow(diameter, 3) / 6;

                    //Which kind?
                    if (diameter < 2)
                    {
                        hazelVolume += volume;
                        hazelCount++;
                        Console.WriteLine("Added hazelnut.");
                    }
                    else
                    {
                        walVolume += volume;
                        walCount++;
                        Console.WriteLine("Added walnut.");
                    }
                }
            } while (diameter > 0);

            //Calculate avg volume:
            double avgHazelVolume = 0, avgWalVolume = 0;

            if (hazelCount > 0)
            {
                avgHazelVolume = hazelVolume / hazelCount;
            }

            if (walCount > 0)
            {
                avgWalVolume = walVolume / walCount;
            }

            //Print summary:
            Console.WriteLine("Hazelnuts: {0}, avg. volume: {1}", hazelCount, avgHazelVolume);
            Console.WriteLine("Walnuts: {0}, avg. volume: {1}", walCount, avgWalVolume);
        }
    }
}
