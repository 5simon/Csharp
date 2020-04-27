using System;

namespace Lesson5
{
    class Dice
    {
        static void Main()
        {
            //How many dice rolls?
            int rolls = 1000;

            //Create a random number generator:
            Random rand = new Random();

            //Counters for the results:
            //a: 3 - 15, b: 16, c: 17, d: 18
            int a = 0, b = 0, c = 0, d = 0;

            for (int i = 0; i < rolls; i++)
            {
                //Roll the dices:
                int result = rand.Next(1, 7) + rand.Next(1, 7) + rand.Next(1, 7);

                switch (result)
                {
                case 16: b++; break;
                case 17: c++; break;
                case 18: d++; break;
                default: a++; break;
                }
            }

            //Calculate the result:
            Console.WriteLine("3 - 15: {0} times", a);
            Console.WriteLine("    16: {0} times", b);
            Console.WriteLine("    17: {0} times", c);
            Console.WriteLine("    18: {0} times", d);
            Console.WriteLine("Result: {0} EUR", (b * 5) + (c * 10) + (d * 100) - (rolls * 1));
        }
    }
}