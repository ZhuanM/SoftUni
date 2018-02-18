using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StreetExtraordinaire : Cat
{
    private string name;
    private int decibelsOfMeows;

    public StreetExtraordinaire(string name, int decibelsOfMeows)
        : base(name)
    {
        this.decibelsOfMeows = decibelsOfMeows;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} {base.Name} {decibelsOfMeows}";
    }
}