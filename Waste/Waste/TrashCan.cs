using System;

namespace Waste
{
    //Delegate type conforming to the C# standard pattern:
    delegate void FullTrashCanEventHandler(object sender, TransportEventArgs e);

    class TrashCan
    {
        private readonly double volume;
        private double usedVolume = 0;

        //Some kind of "public delegate field":
        public event FullTrashCanEventHandler OnTrashCanFull;

        public double UsedVolume
        {
            get
            {
                return usedVolume;
            }

            set
            {
                usedVolume = value;

                //Check if volume is exceeded.
                //In that case, trigger the event.
                // 1.) Create a TransportEventArgs object with the used volume.
                // 2.) Trigger the event, pass ourselves as sender and the TransportEventArgs
                //      object as e.

                if (usedVolume >= volume)
                {
                    Console.WriteLine("Event is being triggered ({0:f2} >= {1:f2}).", usedVolume, volume);

                    TransportEventArgs e = new TransportEventArgs(usedVolume);

                    //Events are null as long as no handlers are added.
                    OnTrashCanFull?.Invoke(this, e);
                }
            }
        }

        public TrashCan(double newVolume)
        {
            volume = newVolume;
        }
    }
}
