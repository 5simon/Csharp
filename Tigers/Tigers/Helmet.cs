using System;

namespace Tigers
{
    class Helmet
    {
        public double Diameter
        {
            get;
        }

        public int Firmness
        {
            get;
        }

        public Helmet(double newDiameter, int newFirmness)
        {
            Diameter = newDiameter;
            Firmness = newFirmness;
        }

        public override string ToString()
        {
            return string.Format("Helmet(diameter = {0}, firmness = {1})", Diameter, Firmness);
        }
    }
}
