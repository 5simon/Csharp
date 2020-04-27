using System;

namespace Sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Number n1 = new Number(5);
                Console.WriteLine("n1 = {0}", n1);

                Number n2 = new Number(0);
                Console.WriteLine("n2 = {0}", n2);

                Number n3 = new Number("III");
                Console.WriteLine("n3 = {0}", n3);

                //Error cases:
                //Number n4 = new Number(-1);
                //Number n5 = new Number("IXI");

                Number n6 = new Number(6);
                Console.WriteLine("n6 = {0}", n6);

                Number n7 = new Number(6);
                Console.WriteLine("n7 = {0}", n7);

                Console.WriteLine("{0} + {1} = {2}", n1, n3, n1 + n3);
                Console.WriteLine("{0} - {1} = {2}", n1, n3, n1 - n3);
                Console.WriteLine("{0} / {1} = {2}", n6, n3, n6 / n3);

                Console.WriteLine("Is {0} < {1} ? {2}", n1, n3, n1 < n3);
                Console.WriteLine("Is {0} == {1} ? {2}", n1, n3, n1 == n3);
                Console.WriteLine("Is {0} == {1} ? {2}", n6, n7, n6 == n7);

                //Test "Equals":
                object n6o = n6;
                object n7o = n7;

                Console.WriteLine("Does {0} equal {1} ? {2}", n6o, n7o, n6o.Equals(n7o));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

        }
    }
}
