using System;

namespace Lesson5
{
    class Worldcup
    {
        static void Main()
        {
            //Create the table:
            string[] athletes =
            {
                "Kaisa Mäkäräinen",
                "Anastasiya Kuzmina",
                "Darja Domratschewa",
                "Laura Dahlmeier",
                "Dorothea Wierer",
                "Lisa Vittozzi",
                "Anais Bescond",
                "Veronika Vitková",
                "Franziska Hildebrand",
                "Vanessa Hinz"
            };

            //For-each loop:
            foreach (string athlete in athletes)
            {
                Console.WriteLine(athlete);
            }

            /*
             * For loop:
            for (int i = 0; i < athletes.Length; i++)
            {
                Console.WriteLine("Athlete {0}: {1}", i + 1, athletes[i]);
            }
            */

            //Read indices:
            int index;

            do
            {
                do
                {
                    Console.Write("Index -> ");
                } while (!int.TryParse(Console.ReadLine(), out index));

                //Did we get a nonnegative value?
                if ((index >= 1) && (index <= athletes.Length))
                {
                    Console.WriteLine("Athlete at index {0} is {1}.", index, athletes[index - 1]);
                }
            } while (index < 3);
        }
    }
}
