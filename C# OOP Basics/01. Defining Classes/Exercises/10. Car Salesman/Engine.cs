using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Engine
{
    private string engineModel;
    private int enginePower;

    private int? displacement; // optional // int? return null if int variable isn't set
    private string efficiency; // optional

    public Engine(string engineModel, int enginePower)
    {
        this.EngineModel = engineModel;
        this.EnginePower = enginePower;
    }

    public Engine(string engineModel, int enginePower, int? displacement)
        : this(engineModel, enginePower)
    {
        this.Displacement = displacement;
    }

    public Engine(string engineModel, int enginePower, string efficiency)
        : this(engineModel, enginePower)
    {
        this.Efficiency = efficiency;
    }

    public Engine(string engineModel, int enginePower, int? displacement, string efficiency) 
        : this(engineModel, enginePower)
    {
        this.Displacement = displacement;
        this.Efficiency = efficiency;
    }

    public string EngineModel
    {
        get { return this.engineModel; }
        set { this.engineModel = value; }
    }

    public int EnginePower
    {
        get { return this.enginePower; }
        set { this.enginePower = value; }
    }

    public int? Displacement
    {
        get { return this.displacement; }
        set { this.displacement = value; }
    }

    public string Efficiency
    {
        get { return this.efficiency; }
        set { this.efficiency = value; }
    }
}