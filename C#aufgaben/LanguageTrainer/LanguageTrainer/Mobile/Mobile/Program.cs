using System;

namespace Mobile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get minutes and scale:
            double minutes;
            char scale;

            try
            {
                Console.Write("Minutes -> ");
                minutes = double.Parse(Console.ReadLine());

                Console.Write("Pay scale (S, M, or L) -> ");
                scale = char.Parse(Console.ReadLine().ToUpper());
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad format!");
                return;
            }

            //Calculate cost:
            //Minutes:
            double basicCharge = 3.99;
            double phoneCharge;

            if (minutes > 100)
            {
                phoneCharge = (minutes - 100) * 0.099;
            }
            else
            {
                phoneCharge = 0;
            }

            //Pay scale:
            double scaleCost;

            switch (scale)
            {
            case 'S': scaleCost = 6; break;
            case 'M': scaleCost = 11; break;
            case 'L': scaleCost = 20; break;
            default:

                Console.WriteLine("Bad pay scale (only S, M, or L is allowed)!");
                return;
            }

            //Print result:
            Console.WriteLine("Basic charge: {0:F2} EUR", basicCharge);
            Console.WriteLine("Phone charge: {0:F2} EUR", phoneCharge);
            Console.WriteLine("Mobile data charge: {0:F2} EUR", scaleCost);
            Console.WriteLine("Total charge: {0:F2} EUR", basicCharge + phoneCharge + scaleCost);
        }
    }
}
