using System;

namespace Waste
{
    class TransportEventArgs : EventArgs
    {
        public double GarbageAmount
        {
            get;
        }

        public TransportEventArgs(double newGarbageAmount)
        {
            GarbageAmount = newGarbageAmount;
        }
    }
}
