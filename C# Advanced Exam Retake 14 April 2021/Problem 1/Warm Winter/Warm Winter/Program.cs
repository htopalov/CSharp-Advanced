using System;
using System.Collections.Generic;
using System.Linq;

namespace Warm_Winter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sets = new List<int>();
            int[] hats = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] scarfs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> hatsStack = new Stack<int>(hats);
            Queue<int> scarfsQueue = new Queue<int>(scarfs);

            while (hatsStack.Count > 0 && scarfsQueue.Count > 0)
            {
                int hat = hatsStack.Peek();
                int scarf = scarfsQueue.Peek();
                if (hat > scarf)
                {
                    int set = hat + scarf;
                    hatsStack.Pop();
                    scarfsQueue.Dequeue();
                    sets.Add(set);
                }
                if (scarf > hat)
                {
                    //remove hat and check next one
                    hatsStack.Pop();
                    continue;
                }
                if (hat == scarf)
                {
                    scarfsQueue.Dequeue();
                    int currentHat = hatsStack.Pop() + 1;
                    hatsStack.Push(currentHat);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
