﻿using System;

namespace _17._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (char i = (char)firstNumber; i <= (char)secondNumber; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}