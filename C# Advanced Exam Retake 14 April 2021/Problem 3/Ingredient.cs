﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailParty
{
    public class Ingredient
    {
        private string name;
        private int alcohol;
        private int quantity;

        public Ingredient(string name, int alcohol, int quantity)
        {
            this.Name = name;
            this.Alcohol = alcohol;
            this.Quantity = quantity;
        }

        public string Name 
        {
            get => this.name;
            set => this.name = value;
        }

        public int Alcohol 
        {
            get => this.alcohol;
            set => this.alcohol = value;
        }

        public int Quantity 
        {
            get => this.quantity;
            set => this.quantity = value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ingredient: {this.Name}");
            sb.AppendLine($"Quantity: {this.Quantity}");
            sb.AppendLine($"Alcohol: {this.Alcohol}");

            return sb.ToString().Trim();
        }
    }
}
