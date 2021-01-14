using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsPushCount = nsx[0];
            int elementsPopCount = nsx[1];
            int elementX = nsx[2];
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < elementsPushCount; i++)
            {
                stack.Push(elements[i]);
            }
            for (int i = 0; i < elementsPopCount; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(elementX))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
