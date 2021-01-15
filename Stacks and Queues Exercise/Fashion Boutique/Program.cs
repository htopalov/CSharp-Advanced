using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> box = new Stack<int>(values);
            int currentSum = 0;
            int rackCount = 0;
            while (box.Count>0)
            {
                int cycle = box.Peek();
                if (currentSum+cycle<capacityOfRack)
                {
                    currentSum += box.Pop();
                    if (currentSum< capacityOfRack && box.Count ==0)
                    {
                        rackCount++;
                        break;
                    }
                }
                else if (currentSum+cycle == capacityOfRack)
                {
                    currentSum += box.Pop();
                    rackCount++;
                    currentSum = 0;
                }
                else if (currentSum+cycle > capacityOfRack)
                {
                    rackCount++;
                    currentSum = 0;
                }
            }
            Console.WriteLine(rackCount);
        }
    }
}
