using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                family.AddMember(person);
            }
            Person oldestMan = family.GetOldestMember();
            Console.WriteLine($"{oldestMan.Name} {oldestMan.Age}");
        }
    }
}
