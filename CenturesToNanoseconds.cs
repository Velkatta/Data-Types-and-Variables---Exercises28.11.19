using System;
using System.Numerics;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centures = byte.Parse(Console.ReadLine());

            ushort years = (ushort)(centures * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            BigInteger miliseconds = seconds * 1000;
            BigInteger microseconds = miliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


            //int centures = int.Parse(Console.ReadLine());

            //int years = centures * 100;
            //int days = (int)(years * 365.2422);
            //int hours = days * 24;
            //long mins = hours * 60;
            //long seconds = mins * 60;
            //decimal milisec = seconds * 1000;
            //decimal microsec = milisec * 1000;
            //decimal nanosec = microsec * 1000;

            //Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {mins} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}