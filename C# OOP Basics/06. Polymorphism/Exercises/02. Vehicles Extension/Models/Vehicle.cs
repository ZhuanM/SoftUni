using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelConsumption = fuelConsumption;

        if (fuelQuantity > tankCapacity)
        {
            this.FuelQuantity = 0;
        }
        else
        {
            this.FuelQuantity = fuelQuantity;
        }

        this.TankCapacity = tankCapacity;
    }

    protected double FuelQuantity { get; set; }

    private double FuelConsumption { get; set; }

    private double TankCapacity { get; set; }

    protected abstract double AdditionalConsumption { get; }

    public string Drive(double distance)
    {
        double requiredFuel = (this.FuelConsumption + this.AdditionalConsumption) * distance;

        if (requiredFuel <= FuelQuantity)
        {
            FuelQuantity -= requiredFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        return $"{this.GetType().Name} needs refueling";
    }

    public virtual void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (fuel + FuelQuantity > TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
        }

        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}