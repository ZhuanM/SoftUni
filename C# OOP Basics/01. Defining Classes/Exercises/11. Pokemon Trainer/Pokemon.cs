using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pokemon
{
    private string pokemonName;
    private string element;
    private int health;

    public Pokemon(string pokemonName, string element, int health)
    {
        this.PokemonName = pokemonName;
        this.Element = element;
        this.Health = health;
    }

    public void ReduceHealth()
    {
        this.Health -= 10;
    }

    public string PokemonName
    {
        get { return this.pokemonName; }
        private set { this.pokemonName = value; }
    }

    public string Element
    {
        get { return this.element; }
        private set { this.element = value; }
    }

    public int Health
    {
        get { return this.health; }
        private set { this.health = value; }
    }
}