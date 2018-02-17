using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    private string model;
    private string cargoType;
    private int cargoWeight;
    private int engineSpeed;
    private int enginePower;
    private double tire1Pressure;
    private double tire1Age;
    private double tire2Pressure;
    private double tire2Age;
    private double tire3Pressure;
    private double tire3Age;
    private double tire4Pressure;
    private double tire4Age;

    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
        double tire1Pressure, double tire1Age, double tire2Pressure, double tire2Age,
        double tire3Pressure, double tire3Age, double tire4Pressure, double tire4Age)
    {
        this.Model = model;
        this.EngineSpeed = engineSpeed;
        this.EnginePower = enginePower;
        this.CargoWeight = cargoWeight;
        this.CargoType = cargoType;
        this.Tire1Pressure = tire1Pressure;
        this.Tire1Age = tire1Age;
        this.Tire2Pressure = tire2Pressure;
        this.Tire2Age = tire2Age;
        this.Tire3Pressure = tire3Pressure;
        this.Tire3Age = tire3Age;
        this.Tire4Pressure = tire4Pressure;
        this.Tire4Age = tire4Age;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string CargoType
    {
        get { return this.cargoType; }
        set { this.cargoType = value; }
    }

    public int CargoWeight
    {
        get { return this.cargoWeight; }
        set { this.cargoWeight = value; }
    }

    public int EngineSpeed
    {
        get { return this.engineSpeed; }
        set { this.engineSpeed = value; }
    }

    public int EnginePower
    {
        get { return this.enginePower; }
        set { this.enginePower = value; }
    }

    public double Tire1Pressure
    {
        get { return this.tire1Pressure; }
        set { this.tire1Pressure = value; }
    }

    public double Tire1Age
    {
        get { return this.tire1Age; }
        set { this.tire1Age = value; }
    }

    public double Tire2Pressure
    {
        get { return this.tire2Pressure; }
        set { this.tire2Pressure = value; }
    }

    public double Tire2Age
    {
        get { return this.tire2Age; }
        set { this.tire2Age = value; }
    }

    public double Tire3Pressure
    {
        get { return this.tire3Pressure; }
        set { this.tire3Pressure = value; }
    }

    public double Tire3Age
    {
        get { return this.tire3Age; }
        set { this.tire3Age = value; }
    }

    public double Tire4Pressure
    {
        get { return this.tire4Pressure; }
        set { this.tire4Pressure = value; }
    }

    public double Tire4Age
    {
        get { return this.tire4Age; }
        set { this.tire4Age = value; }
    }
}