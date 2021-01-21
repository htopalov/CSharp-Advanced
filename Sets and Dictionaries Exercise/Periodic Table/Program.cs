using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalSet = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] chemicals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < chemicals.Length; j++)
                {
                    chemicalSet.Add(chemicals[j]);
                }
            }
            Console.WriteLine(string.Join(" ", chemicalSet));
        }
    }
}
