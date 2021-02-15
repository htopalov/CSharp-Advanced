using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Dictionary<string, int> bombPouch = new Dictionary<string, int>();
            bombPouch.Add("Datura Bombs", 0);
            bombPouch.Add("Cherry Bombs", 0);
            bombPouch.Add("Smoke Decoy Bombs", 0);
            bool isFilled = false;
            while (bombEffects.Count>0 && bombCasing.Count>0)
            {
                int sum = bombEffects.Peek() + bombCasing.Peek();
                if (sum == 40)
                {
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                    bombPouch["Datura Bombs"] += 1;
                }
                else if (sum == 60)
                {
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                    bombPouch["Cherry Bombs"] += 1;
                }
                else if (sum == 120)
                {
                    bombEffects.Dequeue();
                    bombCasing.Pop();
                    bombPouch["Smoke Decoy Bombs"] += 1;
                }
                else
                {
                    int[] temp = bombCasing.ToArray();
                    temp[0] -= 5;
                    bombCasing.Clear();
                    for (int i = temp.Length-1; i >= 0; i--)
                    {
                        bombCasing.Push(temp[i]);
                    }
                }
                if (bombPouch["Datura Bombs"] >= 3 && bombPouch["Cherry Bombs"] >= 3 && bombPouch["Smoke Decoy Bombs"] >= 3)
                {
                    isFilled = true;
                    break;
                }

            }

            if (isFilled)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (bombEffects.Count> 0)
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ",bombEffects));
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasing.Count > 0)
            {
                Console.WriteLine("Bomb Casings: " + string.Join(", ", bombCasing));
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            foreach (var bomb in bombPouch.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
