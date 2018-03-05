using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Bus : Vehicle
{
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
        this.airConditionerCondition = AirConditionerCondition.On;
    }

    private const double workingAirConditionerAdditionalConsumption = 1.4;

    private AirConditionerCondition airConditionerCondition;

    protected override double AdditionalConsumption
    {
        get
        {
            if (airConditionerCondition == AirConditionerCondition.On)
            {
                return workingAirConditionerAdditionalConsumption;
            }
            else
            {
                return (double)AirConditionerCondition.Off;
            }
        }
    }

    public void SwitchOnAirConditioner()
    {
        this.airConditionerCondition = AirConditionerCondition.On;
    }

    public void SwitchOffAirConditioner()
    {
        this.airConditionerCondition = AirConditionerCondition.Off;
    }
}