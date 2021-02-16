using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLootBox = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> secondLootBox = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            int sum = 0;
            while (firstLootBox.Count > 0 && secondLootBox.Count > 0)
            {
                if ((firstLootBox.Peek() + secondLootBox.Peek()) % 2 == 0)
                {
                    sum += firstLootBox.Dequeue() + secondLootBox.Pop();

                }
                else
                {
                    firstLootBox.Enqueue(secondLootBox.Pop());
                }
            }
            if (firstLootBox.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            else if (secondLootBox.Count ==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            if (sum >=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {sum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {sum}");
            }
        }
    }
}
