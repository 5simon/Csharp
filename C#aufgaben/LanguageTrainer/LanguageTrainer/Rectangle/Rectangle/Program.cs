using System;

class Rectangle
{
    static void Main()
    {
        //Read values:
        double x1, x2, y1, y2, x, y;

        try
        {
            Console.Write("x1 -> ");
            x1 = double.Parse(Console.ReadLine());

            Console.Write("x2 -> ");
            x2 = double.Parse(Console.ReadLine());

            Console.Write("y1 -> ");
            y1 = double.Parse(Console.ReadLine());

            Console.Write("y2 -> ");
            y2 = double.Parse(Console.ReadLine());

            Console.Write("x -> ");
            x = double.Parse(Console.ReadLine());

            Console.Write("y -> ");
            y = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong number format!");
            return;
        }

        //First check:
        bool is_in_x_range = (x >= x1) && (x <= x2);
        Console.WriteLine("Is x contained in [x1...x2]? {0}", is_in_x_range);

        //Second check:
        bool is_in_y_range = (y >= y1) && (y <= y2);
        Console.WriteLine("Is y contained in [y1...y2]? {0}", is_in_y_range);
        Console.WriteLine("Is (x, y) contained in rect (x1, x2, y1, y2)? {0}", is_in_x_range && is_in_y_range);

        //Third check:
        Console.WriteLine("Is x contained in [x1...x2] OR y contained in [y1...y2]? {0}", is_in_x_range || is_in_y_range);
    }
}
