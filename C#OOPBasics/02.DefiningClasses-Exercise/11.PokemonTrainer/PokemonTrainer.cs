using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonTrainer
{
    public static void Main()
    {
        var trainers = new List<Trainer>();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            var TrainerAndPokemonInfo = input
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var trainerName = TrainerAndPokemonInfo[0];
            var pokemonName = TrainerAndPokemonInfo[1];
            var pokemonElement = TrainerAndPokemonInfo[2];
            var pokemonHealth = int.Parse(TrainerAndPokemonInfo[3]);

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (trainers.FirstOrDefault(t => t.Name == trainerName) == null)
            {
                var trainer = new Trainer(trainerName);
                trainer.PokemonCollection.Add(pokemon);
                trainers.Add(trainer);
            }
            else
            {
                trainers.FirstOrDefault(t => t.Name == trainerName).PokemonCollection.Add(pokemon);
            }
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.PokemonCollection.FirstOrDefault(p => p.Element == input) == null)
                {
                    foreach (var pokemon in trainer.PokemonCollection)
                    {
                        pokemon.Health -= 10;
                    }
                    trainer.PokemonCollection.RemoveAll(p => p.Health <= 0);
                }
                else
                {
                    trainer.NumberOfBadges++;
                }
            }

        }

        foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
        }
    }
}