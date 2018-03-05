using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }

    public string Name { get; set; }

    public double Weight { get; private set; }

    public int FoodEaten { get; set; }

    protected abstract double WeightPerFood { get; }

    public abstract string ProduceSound();

    protected void Throw(Food food)
    {
        throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
    }

    protected abstract void ValidateFood(Food food);

    public virtual void EatFood(Food food)
    {
        ValidateFood(food);

        this.FoodEaten += food.Quantity;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, ";
    }
}