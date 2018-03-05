using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    { }

    protected override double WeightPerFood => 0.1;

    public override string ProduceSound() => "Squeak";

    protected override void ValidateFood(Food food)
    {
        if (food.GetType().Name != nameof(Vegetable) && food.GetType().Name != nameof(Fruit))
        {
            this.Throw(food);
        }
    }

    public override string ToString()
    {
        return base.ToString() + $"{Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
    }
}