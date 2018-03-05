using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    { }

    protected override double WeightPerFood => 0.3;

    public override string ProduceSound() => "Meow";

    protected override void ValidateFood(Food food)
    {
        if (food.GetType().Name != nameof(Vegetable) && food.GetType().Name != nameof(Meat))
        {
            this.Throw(food);
        }
    }
}