using System;

namespace Animals
{
    abstract class Fish: Pet
    {
        public abstract void Swim();

        public override void Attend()
        {
            Console.WriteLine("{0}'s water is being swapped out.", Name);
        }

        public Fish(string newName, string newOwner)
            : base(newName, newOwner)
        {

        }

        public Fish(string newName)
            : base(newName)
        {

        }
    }
}
