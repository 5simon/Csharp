using System;

namespace Tigers
{
    class Tiger
    {
        public int RegID
        {
            get;
        }

        public double Circumference
        {
            get;
        }

        //"virtual" => "can be overwritten by subclasses"
        //"virtual" aktiviert dynamische Bindung!
        public virtual int Firmness
        {
            get;
        }

        public Tiger(int newRegID, double newCircumference, int newFirmness)
        {
            //Assigning to get-only properties works *only from constructor*!
            //Otherwise: private set;
            RegID = newRegID;
            Circumference = newCircumference;
            Firmness = newFirmness;
        }

        //Override System.Object's "ToString()" method:
        public override string ToString()
        {
            return string.Format("Tiger(regID = {0}, circumference = {1}, firmness = {2})",
                RegID, Circumference, Firmness);
        }
    }
}
