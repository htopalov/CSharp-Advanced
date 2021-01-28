using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();
            Predicate<int> myPred;
            if (command == "even")
            {
                myPred = x => x % 2 == 0;
            }
            else
            {
                myPred = x => x % 2 != 0;
            }

        }
        static void Filter(int[] arr, Predicate<int> test)
        {
            List<int> result = new List<int>();
            for (int i = arr[0]; i < arr[1]; i++)
            {
                if (test(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
