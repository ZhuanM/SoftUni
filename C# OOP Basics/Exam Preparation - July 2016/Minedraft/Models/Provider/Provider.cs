﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Provider : Model
{
    private const double MAX_ENERGY_OUTPUT = 10_000;

    private double energyOutput;

    public double EnergyOutput
    {
        get { return energyOutput; }
        private set
        {
            if (value < 0 || value > MAX_ENERGY_OUTPUT)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            energyOutput = value;
        }
    }

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }
}