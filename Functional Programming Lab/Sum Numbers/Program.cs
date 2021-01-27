using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parse = str => int.Parse(str);
            int[] nums = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parse).ToArray();
            Console.WriteLine(nums.Length);
            Console.WriteLine(nums.Sum());
        }

    }
}
