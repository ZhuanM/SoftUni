using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    { }

    private const double additionalConsumption = 1.6;

    protected override double AdditionalConsumption => additionalConsumption;

    private const double refuelingCoefficient = 0.95;

    public override void Refuel(double fuel)
    {
        base.Refuel(fuel * refuelingCoefficient);
    }
}