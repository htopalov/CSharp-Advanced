using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemonCollection;
        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.PokemonCollection = new List<Pokemon>();
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
        public int NumberOfBadges
        {
            get
            {
                return numberOfBadges;
            }
            set
            {
                this.numberOfBadges = value;
            }
        }
        public List<Pokemon> PokemonCollection
        {
            get
            {
                return pokemonCollection;
            }
            set
            {
                this.pokemonCollection = value;
            }
        }
    }
}
