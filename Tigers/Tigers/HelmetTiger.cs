using System;

namespace Tigers
{
    //HelmetTiger "is a" Tiger!
    class HelmetTiger : Tiger
    {
        private Helmet helmet;

        public Helmet TigerHelmet
        {
            get
            {
                return helmet;
            }

            set
            {
                //Calculate the helmet's circumference:
                double helmetCircumference = value.Diameter * Math.PI;

                //Compare with tiger's skull circumference:
                if (helmetCircumference >= Circumference)
                {
                    helmet = value;
                }
                else
                {
                    helmet = null;
                }
            }
        }

        public override int Firmness
        {
            get
            {
                int helmetFirmness = (TigerHelmet != null) ? TigerHelmet.Firmness : 0;
                return helmetFirmness + base.Firmness;
            }
        }

        public HelmetTiger(int newRegID, double newCircumference, int newFirmness)
            : base(newRegID, newCircumference, newFirmness) //Call base class constructor
        {

        }

        //Second constructor, 4 parameters (also helmet)
        //Überladung
        public HelmetTiger(int newRegID, double newCircumference, int newFirmness, Helmet newHelmet)
            : base(newRegID, newCircumference, newFirmness) //Call base class constructor
        {
            TigerHelmet = newHelmet;
        }

        public override string ToString()
        {
            //Ternary operator: ?
            string helmetString = (TigerHelmet != null) ? TigerHelmet.ToString() : "<not present>";

            //string helmetString = TigerHelmet?.ToString() ?? "<not present>";

            return string.Format("HelmetTiger(regID = {0}, circumference = {1}, firmness = {2}, helmet = {3})",
                RegID, Circumference, Firmness, helmetString);
        }
    }
}
