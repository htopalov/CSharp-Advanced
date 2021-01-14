using System;
using System.Collections.Generic;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);
            int currentPosition = 0;
            while (kids.Count > 1)
            {
                currentPosition++;
                string kid = kids.Dequeue();
                if (currentPosition == n)
                {
                    currentPosition = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    kids.Enqueue(kid);
                }
            }
            Console.WriteLine("Last is " + kids.Dequeue());
        }
    }
}
