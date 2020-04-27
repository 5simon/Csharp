using System;

namespace Animals
{
    class Bunny: Mammal
    {
        public override void Attend()
        {
            Console.WriteLine("{0}'s cage is being cleaned.", Name);
        }

        public override void Move()
        {
            Console.WriteLine("{0} scuttles around.", Name);
        }

        public Bunny(string newName, string newOwner)
            : base(newName, newOwner)
        {

        }

        public Bunny(string newName)
            : base(newName)
        {

        }
    }
}
