using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car : Vehicle
{
    public Car(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    { }

    private const double additionalConsumption = 0.9;

    protected override double AdditionalConsumption => additionalConsumption;
}