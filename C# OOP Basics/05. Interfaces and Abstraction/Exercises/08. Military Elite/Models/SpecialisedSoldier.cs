using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private Corps corps;

    public string Corps
    {
        get => this.corps.ToString();
        set
        {
            Corps corps;
            if (!Enum.TryParse(value, out corps))
            {
                throw new ArgumentException();
            }

            this.corps = corps;
        }
    }

    public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine($"Corps: {Corps}");

        return builder.ToString().TrimEnd();
    }
}