using System;

namespace Laba_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = -1 * Math.PI; x < Math.PI; x += Math.PI / 10)
            {
                double y = 5 * x * Math.Sin(x);
                Console.WriteLine("y = {1:f4} x = {0:f4}", x, y);
            }
        }
    }
}

