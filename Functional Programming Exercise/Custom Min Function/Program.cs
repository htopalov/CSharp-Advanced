using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> minValue = MinFuction;
            Console.WriteLine(minValue(numbers));
        }

        private static int MinFuction(int[] nums)
        {
            int current = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < current)
                {
                    current = nums[i];
                }
            }
            return current;
        }
    }
}
