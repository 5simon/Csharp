using System;

namespace Animals
{
    class Guppy: Fish
    {
        public override void Swim()
        {
            Console.WriteLine("{0} swims back and forth.", Name);
        }

        public Guppy(string newName, string newOwner)
           : base(newName, newOwner)
        {

        }

        public Guppy(string newName)
            : base(newName)
        {

        }
    }
}
