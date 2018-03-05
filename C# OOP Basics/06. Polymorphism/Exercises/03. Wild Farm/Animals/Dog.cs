using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    { }

    protected override double WeightPerFood => 0.4;

    public override string ProduceSound() => "Woof!";

    protected override void ValidateFood(Food food)
    {
        if (food.GetType().Name != nameof(Meat))
        {
            this.Throw(food);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
    }
}