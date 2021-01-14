using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> numbers = new Stack<string>(input);
            while (numbers.Count > 1)
            {
                int calc = 0;
                int first = int.Parse(numbers.Pop());
                string operation = numbers.Pop();
                int second = int.Parse(numbers.Pop());
                if (operation == "+")
                {
                    calc = first + second;
                }
                else
                {
                    calc = first - second;
                }
                numbers.Push(calc.ToString());
            }
            Console.WriteLine(numbers.Pop().ToString());
        }
    }
}
