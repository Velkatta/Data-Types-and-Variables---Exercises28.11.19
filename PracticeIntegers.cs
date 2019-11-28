using System;

namespace _01._Practice_Integers
{
    class Program
    {
        static void Main(string[] args)
        {

            sbyte firstNum = sbyte.Parse(Console.ReadLine());  //-100
            byte secondNum = byte.Parse(Console.ReadLine());   //128
            short thirdNum = short.Parse(Console.ReadLine());     //-3540
            ushort fourthNum = ushort.Parse(Console.ReadLine());  //64876
            uint fifthNum = uint.Parse(Console.ReadLine());      //2147483648
            int sixthNum = int.Parse(Console.ReadLine());         //-1141583228
            long seventhNum = long.Parse(Console.ReadLine());   //-1223372036854775808

            Console.WriteLine($"{firstNum}");
            Console.WriteLine($"{secondNum}");
            Console.WriteLine($"{thirdNum}");
            Console.WriteLine($"{fourthNum}");
            Console.WriteLine($"{fifthNum}");
            Console.WriteLine($"{sixthNum}");
            Console.WriteLine($"{seventhNum}");
        }
    }
}