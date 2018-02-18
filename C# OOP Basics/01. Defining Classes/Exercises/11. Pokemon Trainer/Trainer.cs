using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Trainer
{
    private string trainerName;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string trainerName)
    {
        this.TrainerName = trainerName;
        this.Pokemons = new List<Pokemon>();
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.Pokemons.Add(pokemon);
    }

    public void IncreaseBadges()
    {
        this.Badges++;
    }

    public void DecreasePokemonsHealth()
    {
        this.Pokemons.ForEach(p => p.ReduceHealth());
    }

    public void RemoveDeadPokemons()
    {
        this.Pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
    }

    public string TrainerName
    {
        get { return this.trainerName; }
        private set { this.trainerName = value; }
    }

    public int Badges
    {
        get { return this.badges; }
        private set { this.badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        private set { this.pokemons = value; }
    }
}