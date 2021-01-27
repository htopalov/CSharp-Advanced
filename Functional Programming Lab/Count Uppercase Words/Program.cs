using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, bool> func = x => char.IsUpper(x[0]);
            string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(func).ToArray();
            foreach (var item in splitted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
