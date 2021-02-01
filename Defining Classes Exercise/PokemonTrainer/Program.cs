using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            Dictionary<string, Trainer> trainerCollection = new Dictionary<string, Trainer>();
            while (firstInput !="Tournament")
            {
                string[] splitted = firstInput.Split();
                string trainerName = splitted[0];
                string pokemonName = splitted[1];
                string pokemontElement = splitted[2];
                int pokemonHealth = int.Parse(splitted[3]);
                Trainer trainer = new Trainer(trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, pokemontElement, pokemonHealth);
                if (!trainerCollection.ContainsKey(trainerName))
                {
                    trainerCollection[trainerName] = trainer;
                }
                trainerCollection[trainerName].PokemonCollection.Add(pokemon);
                firstInput = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "End")
            {
                foreach (var trainer in trainerCollection.Values)
                {
                    if (trainer.PokemonCollection.Any(p => p.Element == secondInput))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.PokemonCollection)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                }
                foreach (var trainer in trainerCollection.Values)
                {
                    for (int i = 0; i < trainer.PokemonCollection.Count; i++)
                    {
                        if (trainer.PokemonCollection[i].Health <= 0)
                        {
                            trainer.PokemonCollection.RemoveAt(i);
                            i--;
                        }
                    }

                }

                secondInput = Console.ReadLine();
            }
            foreach (var item in trainerCollection.OrderByDescending(x=>x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{item.Key} {item.Value.NumberOfBadges} {item.Value.PokemonCollection.Count}");
            }
        }
    }
}
