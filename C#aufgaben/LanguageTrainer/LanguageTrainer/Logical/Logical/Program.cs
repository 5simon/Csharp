using System;

class Logical
{
    static void Main()
    {
        //Define variables:
        int x = 0b0001_0001;
        int y = 0b1000_1000;
        int z = 0b1111;

        //Calculate results:
        Console.WriteLine("x & y = 0x{0:X8}", x & y);
        Console.WriteLine("(x | y) & z = 0x{0:X8}", (x | y) & z);
        Console.WriteLine("~(x ^ y) = 0x{0:X8}", ~(x ^ y));
        Console.WriteLine("~(x ^ y) & byte.MaxValue = 0x{0:X8}", ~(x ^ y) & byte.MaxValue);

        //Transforming x into y:
        int transformed_x = x >> 3;
        Console.WriteLine("Is transformation correct? {0}", transformed_x == y);
    }
}
