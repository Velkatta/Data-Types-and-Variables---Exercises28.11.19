using System;

namespace _07._Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());   // 5
            int b = int.Parse(Console.ReadLine());   // 10

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            int temp = a;                         // temp = 5
            a = b;                                // á = 10
            b = temp;                             // b = 5

            Console.WriteLine("After:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}