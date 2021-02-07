using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Add(input);
            }
            Box<string> box = new Box<string>(list);
            string valueToCompare = Console.ReadLine();
            Console.WriteLine(box.Comparator(valueToCompare)); 
            
        }
    }
}
