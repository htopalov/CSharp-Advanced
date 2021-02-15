using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int taskToKill = int.Parse(Console.ReadLine());

            while (tasks.Count>0)
            {
                int task = tasks.Peek();
                int thread = threads.Peek();
                if (thread >= task && taskToKill != task)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                if (taskToKill == task)
                {
                    Console.WriteLine($"Thread with value {thread} killed task {taskToKill}");
                    Console.WriteLine(string.Join(" ", threads));
                    break;
                }
                else if (thread < task)
                {
                    threads.Dequeue();
                }

            }
        }
    }
}
