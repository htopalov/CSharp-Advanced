using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        Func<int, int> addFunc = x => x + 1;
                        numbers = Calculator(numbers, addFunc);
                        break;
                    case "multiply":
                        Func<int, int> multiFunc = x => x * 2;
                        numbers = Calculator(numbers, multiFunc);
                        break;
                    case "subtract":
                        Func<int, int> subtFunc = x => x - 1;
                        numbers = Calculator(numbers, subtFunc);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
                command = Console.ReadLine();
            }
        }
        static List<int> Calculator(List<int> list, Func<int, int> passedFunc) => list.Select(passedFunc).ToList();
    }
}
