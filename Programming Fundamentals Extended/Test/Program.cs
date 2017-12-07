using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pokemon Evolution exercise
            var pokemonDict = new Dictionary<string, Dictionary<string, List<long>>>();

            string input = Console.ReadLine();

            while (input != "wubbalubbadubdub")
            {
                string[] tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1) //{pokemonName} -> {evolutionType} -> {evolutionIndex}
                {
                    string pokemonName = tokens[0];
                    string evolutionType = tokens[1];
                    long evolutionIndex = long.Parse(tokens[2]);

                    if (!pokemonDict.ContainsKey(pokemonName))
                    {
                        pokemonDict.Add(pokemonName, new Dictionary<string, List<long>>());
                    }
                    if (!pokemonDict[pokemonName].ContainsKey(evolutionType))
                    {
                        pokemonDict[pokemonName].Add(evolutionType, new List<long>());
                    }
                    pokemonDict[pokemonName][evolutionType].Add(evolutionIndex);


                }
                else if (tokens.Length == 1) //Only pokemon name
                {
                    string pokemonName = tokens[0];

                    if (pokemonDict.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var item in pokemonDict[pokemonName])
                        {
                            Console.WriteLine($"{item.Key} <-> {item.Value}");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            //OUTPUT
            foreach (var item in pokemonDict)
            {
                Console.WriteLine($"# {item.Key}");
                if (item.Value.Values.Count > 1)
                {

                }
                foreach (var inner in item.Value)
                {
                    Console.WriteLine($"{inner.Key} <-> {inner.Value}");
                }
            }
        }
    }
}