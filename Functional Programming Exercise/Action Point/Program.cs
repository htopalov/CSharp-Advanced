using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string> myAction = PrintStrings;
            for (int i = 0; i < strings.Length; i++)
            {
                myAction(strings[i]);
            }
        }

        private static void PrintStrings(string str)
        {
            Console.WriteLine(str);
        }
    }
}
