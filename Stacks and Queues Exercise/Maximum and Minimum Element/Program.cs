using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string action = input[0];
                switch (action)
                {
                    case "1":
                        int pushed = int.Parse(input[1]);
                        numbers.Push(pushed);
                        break;
                    case "2":
                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case "3":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}
