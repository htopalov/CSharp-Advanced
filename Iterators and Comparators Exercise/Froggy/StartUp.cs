using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> inputStones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake myLake = new Lake(inputStones);
            Console.WriteLine(string.Join(", ",myLake));
        }
    }
}
