using System;

namespace Animals
{
    class Cat: Mammal
    {
        private static readonly Random CatRandom = new Random();

        public override void Attend()
        {
            Console.WriteLine("{0}'s fur is being brushed.", Name);
        }

        public override void Move()
        {
            Console.WriteLine("{0} sneaks around.", Name);
        }

        public override void Stroke()
        {
            base.Stroke();
            Console.WriteLine("{0} purrs.", Name);

            //Maybe bite:
            if (CatRandom.Next(5) == 4)
            {
                Console.WriteLine("{0} bites!", Name);
            }
        }

        public Cat(string newName)
            : base(newName)
        {

        }
    }
}
