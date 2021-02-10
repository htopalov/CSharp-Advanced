using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "END")
            {
                Person person = new Person(input[0], int.Parse(input[1]), input[2]);
                persons.Add(person);
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            int n = int.Parse(Console.ReadLine());
            int equal = 0;
            int different = 0;
            Person personToCompare = persons[n - 1];
            persons.Remove(persons[n - 1]);
            foreach (var item in persons)
            {
                int result = personToCompare.CompareTo(item);
                if (result == 0)
                {
                    equal++;
                }
                else
                {
                    different++;
                }
            }
            if (equal > 0)
            {
                Console.WriteLine($"{equal + 1} {different} {persons.Count + 1}");
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }
    }
}
