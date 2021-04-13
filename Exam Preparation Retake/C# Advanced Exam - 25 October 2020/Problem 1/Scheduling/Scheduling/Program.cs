using System;
using System.Collections.Generic;
using System.Linq;

namespace Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] threads = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int taskToKill = int.Parse(Console.ReadLine());

            Stack<int> taskStack = new Stack<int>(tasks);
            Queue<int> threadsQueue = new Queue<int>(threads);

            while (taskStack.Count > 0)
            {
                int task = taskStack.Peek();
                int thread = threadsQueue.Peek();
                if (thread >= task && task != taskToKill)
                {
                    taskStack.Pop();
                    threadsQueue.Dequeue();
                }
                if (task == taskToKill)
                {
                    Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", threadsQueue));
                    break;
                }
                else if (thread < task)
                {
                    threadsQueue.Dequeue();
                }
            }
        }
    }
}
