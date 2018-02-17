using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    private string model;
    private decimal fuelAmount;
    private decimal fuelConsumptionPerKm;
    private decimal distanceTraveled;

    public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKm)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public decimal FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public decimal FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        set { this.fuelConsumptionPerKm = value; }
    }

    public decimal DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public bool CanMoveDistance(decimal amountOfKm)
    {
        if (amountOfKm * FuelConsumptionPerKm <= FuelAmount)
        {
            FuelAmount -= FuelConsumptionPerKm * amountOfKm;
            DistanceTraveled += amountOfKm;
            return true;
        }

        return false;
    }
}