using System;

namespace _09._Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = char.Parse(Console.ReadLine());
            //char b = char.Parse(Console.ReadLine());
            //char c = char.Parse(Console.ReadLine());

            //Console.WriteLine($"{c}{b}{a}");

            char[] array = new char[3];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
            }
            Array.Reverse(array);
            string result = new string(array);
            Console.WriteLine(result);
        }
    }
}