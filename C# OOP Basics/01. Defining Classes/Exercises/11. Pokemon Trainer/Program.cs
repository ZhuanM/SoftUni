using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new List<Trainer>();

        string input;
        while ((input = Console.ReadLine()) != "Tournament")
        {
            string[] inputTokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string trainerName = inputTokens[0];
            string pokemonName = inputTokens[1];
            string pokemonElement = inputTokens[2];
            int pokemonHealth = int.Parse(inputTokens[3]);

            if (!trainers.Any(t => t.TrainerName == trainerName))
            {
                trainers.Add(new Trainer(trainerName));
            }

            Trainer trainer = trainers.First(t => t.TrainerName == trainerName);

            trainer.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
        }

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.IncreaseBadges();
                }
                else
                {
                    trainer.DecreasePokemonsHealth();
                    trainer.RemoveDeadPokemons();
                }
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.TrainerName} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}