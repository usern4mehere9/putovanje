using System;

namespace Putovanje
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, s, t;
            v = double.Parse(Console.ReadLine());
            s = double.Parse(Console.ReadLine());

            t = s / v;

            Console.WriteLine(Math.Round(t,2));
        }
    }
}
