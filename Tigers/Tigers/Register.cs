using System;

namespace Tigers
{
    class Register
    {
        public Tiger[] Tigers
        {
            get;
        }

        //Indexer (= special property):
        //Allows access via [index]
        public Tiger this[int i]
        {
            get
            {
                return Tigers[i];
            }
        }

        //Optional parameter: Has a default value
        public Register(int count = 2)
        {
            Tigers = new Tiger[count];
        }

        public Register(Tiger[] newTigers)
        {
            Tigers = newTigers;
        }

        public Tiger FindTiger(int regID)
        {
            //Find first tiger with given regID or return null.
            foreach (Tiger tiger in Tigers)
            {
                if (tiger.RegID == regID)
                {
                    return tiger;
                }
            }

            return null;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Main method in Register class ...");
            Tiger[] tigers = new Tiger[]
            {
                new Tiger(42, 50, 7),
                new Tiger(101, 53, 3),
                new HelmetTiger(101010, 60, 6),
                new HelmetTiger(666, 59, 5, new Helmet(20, 2))
            };

            //Iterate through the array (foreach), print each tiger
            //Polymorphism / Polymorphie: Call subclass method via baseclass reference
            //Polymorphie nur mit dynamischer Bindung (= virtuelle Methoden)!
            foreach (Tiger tiger in tigers)
            {
                Console.WriteLine("{0}", tiger);

                //Test if current tiger is a HelmetTiger:
                //Console.WriteLine("Is HelmetTiger: {0}", tiger is HelmetTiger);

                //Try to cast from baseclass to subclass => down-cast
                HelmetTiger helmetTiger = tiger as HelmetTiger;

                if (helmetTiger != null)
                {
                    Console.WriteLine("Is HelmetTiger: {0}", helmetTiger.TigerHelmet);
                }
            }

            //Create a new register from the existing array:
            Register reg = new Register(tigers);

            //Print second tiger from register via indexer:
            Console.WriteLine("Second tiger: {0}", reg[1]);

            Tiger firstSearchTiger = reg.FindTiger(666);
            Tiger secondSearchTiger = reg.FindTiger(777);

            Console.WriteLine("Tiger with ID 666: {0}", firstSearchTiger);
            Console.WriteLine("Tiger with ID 777: {0}", secondSearchTiger);
        }
    }
}
