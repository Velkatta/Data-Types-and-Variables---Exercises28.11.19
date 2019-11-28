using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double time = seconds + minutes * 60 + hours * 3600;  // time in seconds

            double meterPerSeconds = distanceInMeters / time;
            double kmPerHour = (distanceInMeters / 1000) / (time / 3600);
            double milesPerHour = (distanceInMeters / 1609) / (time / 3600);

            Console.WriteLine($"{meterPerSeconds:0.######}");
            Console.WriteLine($"{kmPerHour:0.######}");
            Console.WriteLine($"{milesPerHour:0.######}");

            //int distanceInMeters = int.Parse(Console.ReadLine());
            //int hours = int.Parse(Console.ReadLine());
            //int minutes = int.Parse(Console.ReadLine());
            //int seconds = int.Parse(Console.ReadLine());

            //int time = seconds + minutes * 60 + hours * 3600;  // time in seconds

            //float metersPerSeconds = (float)distanceInMeters / time;
            //float kmPerHour = ((float)distanceInMeters / 1000) / ((float)time / 3600);
            //float milesPerHour = ((float)distanceInMeters / 1609) / ((float)time / 3600);

            //Console.WriteLine($"{metersPerSeconds:0.######}");
            //Console.WriteLine($"{kmPerHour:0.######}");
            //Console.WriteLine($"{milesPerHour:0.######}");
        }
    }
}