using System;

namespace Animals
{
    abstract class Mammal: Pet, IStrokeable
    {
        public abstract void Move();

        public virtual void Stroke()
        {
            Console.WriteLine("{0} is being stroked :)", Name);
        }

        public Mammal(string newName, string newOwner)
            : base(newName, newOwner)
        {

        }

        public Mammal(string newName)
            : base(newName)
        {

        }
    }
}
