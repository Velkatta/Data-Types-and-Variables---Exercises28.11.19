using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string readXex = Console.ReadLine();

            int number = Convert.ToInt32(readXex, 16);

            Console.WriteLine($"{number}");
        }
    }
}