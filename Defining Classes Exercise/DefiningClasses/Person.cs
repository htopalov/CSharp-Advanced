using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;
        public Person()
        {
           //this.Name = "No name";
            //this.Age = 1;
            People = new List<Person>();
        }
        public Person(int age)
            : this()
        {
            this.Age = age;
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
        public List<Person> People { get; set; }
         public void AddPersonToList(Person man)
        {
            People.Add(man);
        }
        public void FilterMethod()
        {
            People = People.Where(x => x.Age > 30).ToList();
            People = People.OrderBy(y => y.Name).ToList();
            foreach (var person in People)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
