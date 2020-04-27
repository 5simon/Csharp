using System;
using System.Threading;

namespace Waste
{
    class Program
    {
        static void Main(string[] args)
        {
            TrashCan t = new TrashCan(1000);
            GarbageTruck truck = new GarbageTruck();
            Random rand = new Random();

            //Register the garbage truck as handler for the can's event:
            t.OnTrashCanFull += truck.HandleFullTrashCan;

            while (true)
            {
                double newGarbage = 100 * rand.NextDouble();
                Console.WriteLine("Adding {0:f2}l new garbage to the can ...", newGarbage);
                t.UsedVolume += newGarbage;
                Console.WriteLine("Garbage amount is now {0:f2}l.", t.UsedVolume);
                Thread.Sleep(500);
            }
        }
    }
}
