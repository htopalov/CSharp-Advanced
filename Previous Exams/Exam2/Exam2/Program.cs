using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Dictionary<string, int> products = new Dictionary<string, int>();
            products.Add("Bread", 0);
            products.Add("Cake", 0);
            products.Add("Pastry", 0);
            products.Add("Fruit Pie", 0);
            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int liquid = liquids.Peek();
                int ingredient = ingredients.Peek();
                int sum = liquid + ingredient;
                if (sum == 25)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Bread"] += 1;
                }
                else if (sum == 50)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Cake"] += 1;
                }
                else if (sum == 75)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Pastry"] += 1;
                }
                else if (sum == 100)
                {
                    liquids.Dequeue();
                    ingredients.Pop();
                    products["Fruit Pie"] += 1;
                }
                else
                {
                    liquids.Dequeue();
                    int[] temp = ingredients.ToArray();
                    temp[0] += 3;
                    ingredients.Clear();
                    for (int i = temp.Length - 1; i >= 0; i--)
                    {
                        ingredients.Push(temp[i]);
                    }
                }
            }
            if (products["Bread"] >= 1 && products["Cake"] >= 1 && products["Pastry"] >= 1 && products["Fruit Pie"] >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(string.Join(", ", liquids));
            }
            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write("Ingredients left: ");
                Console.WriteLine(string.Join(", ", ingredients));
            }
            foreach (var item in products.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
