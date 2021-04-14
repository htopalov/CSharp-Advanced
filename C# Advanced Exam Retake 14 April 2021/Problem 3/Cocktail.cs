using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> Ingredients;
        private string name;
        private int capacity;
        private int maxAlcoholLevel;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Ingredients = new List<Ingredient>();
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
        }

        public int CurrentAlcoholLevel => Ingredients.Sum(x => x.Alcohol);

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public int Capacity 
        {
            get => this.capacity;
            set => this.capacity = value;
        }

        public int MaxAlcoholLevel 
        {
            get => this.maxAlcoholLevel;
            set => this.maxAlcoholLevel = value;
        }

        public void Add(Ingredient ingredient)
        {

            if (!Ingredients.Contains(ingredient) && ingredient.Alcohol < MaxAlcoholLevel && ingredient.Quantity <= Capacity)
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
            var ingredient = Ingredients.FirstOrDefault(x => x.Name == name);
            if (ingredient != null)
            {
                Ingredients.Remove(ingredient);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(x => x.Name == name);
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(x => x.Alcohol).First();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {this.CurrentAlcoholLevel}");
            foreach (var ingredient in Ingredients)
            {
                sb.AppendLine(ingredient.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
