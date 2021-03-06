﻿using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> myPrint = PrintFunction;
            for (int i = 0; i < strings.Length; i++)
            {
                myPrint(strings[i]);
            }
        }

        private static void PrintFunction(string str)
        {
            Console.WriteLine($"Sir " + str);
        }
    }
}
