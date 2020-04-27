using System;

namespace Animals
{
    //Abstract classes cannot be instantiated!
    abstract class Pet
    {
        public string Name
        {
            get;
            set;
        }

        public string Owner
        {
            get;
        }

        //abstract: Method has no implementation.
        // => "Method is only defined to be overwritten."
        //Abstract methods are automatically virtual!
        public abstract void Attend();

        public Pet(string newName, string newOwner)
        {
            Name = newName;
            Owner = newOwner;
        }

        public Pet(string newName)
            : this(newName, null)
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
