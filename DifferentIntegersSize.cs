using System;

namespace _18._Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string message = "";
            bool canFit = false;

            try
            {
                sbyte first = sbyte.Parse(number);
                message += "* sbyte\r\n";
                canFit = true;
            }
            catch (Exception)
            {
              
            }
            try
            {
                byte first = byte.Parse(number);
                message += "* byte\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                short first = short.Parse(number);
                message += "* short\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                ushort first = ushort.Parse(number);
                message += "* ushort\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                int first = int.Parse(number);
                message += "* int\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                uint first = uint.Parse(number);
                message += "* uint\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }
            try
            {
                long first = long.Parse(number);
                message += "* long\r\n";
                canFit = true;
            }
            catch (Exception)
            {

            }

            if (canFit)
            {
                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine($"{message}");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}