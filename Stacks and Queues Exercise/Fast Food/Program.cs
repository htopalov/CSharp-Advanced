using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orderQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(orderQuantity);
            Console.WriteLine(orders.Max());
            while (foodQuantity >= 0)
            {
                if (orders.Count > 0)
                {
                    int currentClient = orders.Peek();
                    if (foodQuantity >= currentClient)
                    {
                        foodQuantity -= orders.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", orders));
            }
        }
    }
}
