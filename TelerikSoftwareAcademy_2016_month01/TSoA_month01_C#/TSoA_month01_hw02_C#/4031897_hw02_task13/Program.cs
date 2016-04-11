using System;

class Program
{
    static void Main()
    {
        double eps = 0.000001;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        if ( Math.Abs((x - y)) < eps )
            Console.WriteLine("true");
        else
            Console.WriteLine("false");
    }
}