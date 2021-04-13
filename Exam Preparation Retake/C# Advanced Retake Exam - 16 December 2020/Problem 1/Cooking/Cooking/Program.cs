using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] liquids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> liquidQueue = new Queue<int>(liquids);
            Stack<int> ingredientsStack = new Stack<int>(ingredients);

            Dictionary<string, int> products = new Dictionary<string, int>()
            {
                {"Bread", 0 },
                {"Cake", 0 },
                {"Pastry", 0 },
                {"Fruit Pie", 0 }
            };

            while (liquidQueue.Count > 0 && ingredientsStack.Count > 0)
            {
                int liquid = liquidQueue.Peek();
                int ingredient = ingredientsStack.Peek();
                if (liquid + ingredient == 25)
                {
                    products["Bread"] += 1;
                    liquidQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else if (liquid + ingredient == 50)
                {
                    products["Cake"] += 1;
                    liquidQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else if (liquid + ingredient == 75)
                {
                    products["Pastry"] += 1;
                    liquidQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else if (liquid + ingredient == 100)
                {
                    products["Fruit Pie"] += 1;
                    liquidQueue.Dequeue();
                    ingredientsStack.Pop();
                }
                else
                {
                    liquidQueue.Dequeue();
                    int[] modified = ingredientsStack.Reverse().ToArray();
                    modified[modified.Length - 1] += 3;
                    ingredientsStack = new Stack<int>(modified);
                }


            }

            if (products.All(x=>x.Value >= 1))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquidQueue.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquidQueue)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (ingredientsStack.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredientsStack)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }
            foreach (var product in products.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
        }
    }
}
