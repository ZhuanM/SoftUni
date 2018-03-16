using System;
using System.Collections.Generic;
using System.Text;


public abstract class Provider : Model
{
    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value <= 0 || value >= 10000)
            {
                throw new ArgumentException(nameof(EnergyOutput));
            }
            energyOutput = value;
        }
    }
}