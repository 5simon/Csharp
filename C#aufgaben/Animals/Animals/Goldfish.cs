using System;

namespace Animals
{
    class Goldfish: Fish, IStrokeable
    {
        public override void Swim()
        {
            Console.WriteLine("{0} swims around.", Name);
        }

        public void Stroke()
        {
            if (Owner == null)
            {
                Console.WriteLine("{0} is being stroked, but has no owner and swims away :(", Name);
            }
            else
            {
                Console.WriteLine("{0} is being stroked :)", Name);
            }
        }

        public Goldfish(string newName, string newOwner)
            : base(newName, newOwner)
        {

        }

        public Goldfish(string newName)
            : base(newName)
        {

        }
    }
}
