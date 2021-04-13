using System;
using System.Collections.Generic;
using System.Linq;

namespace Loot_box
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] box2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> box1Queue = new Queue<int>(box1);
            Stack<int> box2Stack = new Stack<int>(box2);
            List<int> claimedItems = new List<int>();
            while (box1Queue.Count > 0 && box2Stack.Count > 0)
            {
                int box1Item = box1Queue.Peek();
                int box2Item = box2Stack.Peek();
                if ((box1Item + box2Item) % 2 == 0)
                {
                    claimedItems.Add(box1Item + box2Item);
                    box1Queue.Dequeue();
                    box2Stack.Pop();
                }
                else
                {
                    box1Queue.Enqueue(box2Stack.Pop());
                }
            }

            if (box1Queue.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (box2Stack.Count == 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (claimedItems.Sum() >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems.Sum()}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems.Sum()}");
            }
        }
    }
}
