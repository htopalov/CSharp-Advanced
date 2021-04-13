using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] bombEffects = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] bombCasings = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> effectsQueue = new Queue<int>(bombEffects);
            Stack<int> casingsStack = new Stack<int>(bombCasings);
            Dictionary<string, int> bombs = new Dictionary<string, int>()
            {
                {"Datura Bombs", 0 },
                { "Cherry Bombs", 0},
                {"Smoke Decoy Bombs", 0 }
            };
            while (effectsQueue.Count > 0 && casingsStack.Count > 0)
            {
                int effect = effectsQueue.Peek();
                int casing = casingsStack.Peek();
                if (effect+ casing == 40)
                {
                    effectsQueue.Dequeue();
                    casingsStack.Pop();
                    bombs["Datura Bombs"]++;
                }
                else if (effect + casing == 60)
                {
                    bombs["Cherry Bombs"]++;
                    effectsQueue.Dequeue();
                    casingsStack.Pop();
                }
                else if (effect + casing == 120)
                {
                    bombs["Smoke Decoy Bombs"]++;
                    effectsQueue.Dequeue();
                    casingsStack.Pop();
                }
                else
                {
                    int currentCasing = casingsStack.Pop();
                    currentCasing -= 5;
                    casingsStack.Push(currentCasing);
                }
                if (bombs.All(x=>x.Value >= 3))
                {
                    break;
                }
            }

            if (bombs.All(x => x.Value >= 3))
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }


            if (effectsQueue.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effectsQueue)}");
            }

            if (casingsStack.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casingsStack)}");
            }

            foreach (var bomb in bombs.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
