using System;

namespace Waste
{
    class GarbageTruck
    {
        public double GarbageAmount
        {
            get;
            set;
        }

        public GarbageTruck()
        {
            GarbageAmount = 0;
        }

        private void EmptyTrashCan(TrashCan can, double amountToRemove)
        {
            //Add the amount of garbage from the trashcan to the truck.
            GarbageAmount += amountToRemove;

            //Empty the can.
            can.UsedVolume -= amountToRemove;
        }

        public void HandleFullTrashCan(object sender, TransportEventArgs e)
        {
            //Obtain the trashcan from the sender parameter:
            TrashCan t = (TrashCan)sender;

            //Empty it:
            EmptyTrashCan(t, e.GarbageAmount);
        }
    }
}
