using System;

namespace _16._Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Math.Abs(double.Parse(Console.ReadLine()));
            double b = Math.Abs(double.Parse(Console.ReadLine()));

            double eps = 0.000001;
            double diff = Math.Max(a,b) - Math.Min(a,b);

            if (diff > eps)
            {
                Console.WriteLine("False");
            }
            else if (diff <= eps)
            {
                Console.WriteLine("True");
            }
        }
    }
}