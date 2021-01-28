using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            names = names.Where(x => x.Length <= n).ToArray();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
     
        }
    }
}
