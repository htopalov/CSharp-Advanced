using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;
        private int capacity;
        public Clinic(int capacity)
        {
            this.data = new List<Pet>();
            this.Capacity = capacity;
        }

        public int Capacity 
        {
            get => this.capacity;
            set => this.capacity = value;
        }


        public int Count => data.Count;
        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            var pet = data.FirstOrDefault(x => x.Name == name);
            if (pet != null)
            {
                return data.Remove(pet);
            }

            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            return data.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(x => x.Age).First();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().Trim();
        }
    }
}
