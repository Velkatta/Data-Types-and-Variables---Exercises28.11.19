using System;

namespace _02._Practice_Floating_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());    //3.141592653589793238
            double secondNum = double.Parse(Console.ReadLine());     //1.60217657
            decimal thirdNum = decimal.Parse(Console.ReadLine()); 
                                                     //7.8184261974584555216535342341
            Console.WriteLine($"{firstNum}");
            Console.WriteLine($"{secondNum}");
            Console.WriteLine($"{thirdNum}");
        }
    }
}