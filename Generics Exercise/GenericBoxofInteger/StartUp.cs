﻿using System;

namespace GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Box<int> box = new Box<int>(Convert.ToInt32(input));
                Console.WriteLine(box.ToString());
            }
        }
    }
}
