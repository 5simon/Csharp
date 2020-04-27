using System;

namespace Tigers
{
    class Program
    {
        static void Main(string[] args)
        {
            HelmetTiger tiger = new HelmetTiger(42, 50, 7);
            tiger.TigerHelmet = new Helmet(16, 2);

            Console.WriteLine("Is the helmet present? {0}", tiger.TigerHelmet != null);
            Console.WriteLine("HelmetTiger's ToString() method: {0}", tiger.ToString());
        }
    }
}
