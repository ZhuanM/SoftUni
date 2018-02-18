using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Car
{
    private string carModel;
    private Engine engineModel;

    private int? weight; // optional // int? return null if int variable isn't set
    private string color; // optional

    public Car(string carModel, Engine engineModel)
    {
        this.CarModel = carModel;
        this.EngineModel = engineModel;
    }

    public Car(string carModel, Engine engineModel, int? weight)
        : this(carModel, engineModel)
    {
        this.Weight = weight;
    }

    public Car(string carModel, Engine engineModel, string color)
        : this(carModel, engineModel)
    {
        this.Color = color;
    }

    public Car(string carModel, Engine engineModel, int? weight, string color)
        : this(carModel, engineModel)
    {
        this.Weight = weight;
        this.Color = color;
    }

    public string CarModel
    {
        get { return this.carModel; }
        set { this.carModel = value; }
    }

    public Engine EngineModel
    {
        get { return this.engineModel; }
        set { this.engineModel = value; }
    }

    public int? Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }

    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }
}