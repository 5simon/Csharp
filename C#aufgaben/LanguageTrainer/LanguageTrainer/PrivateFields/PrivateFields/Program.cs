using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateFields
{
    class Program
    {
        static void Test(out int a, out int b, out int c)
        {
            a = 666;
            b = 42;
            c = 0;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Test(out a, out b, out c);

            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
