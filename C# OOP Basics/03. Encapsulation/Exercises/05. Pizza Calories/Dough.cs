using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Dough
{
    private string flourType;

    public string FlourType
    {
        get { return flourType; }
        set
        {
            if (value.ToLower() == "white" || value.ToLower() == "wholegrain") this.flourType = value;
            else throw new ArgumentException("Invalid type of dough.");
        }
    }

    private string bakingTechnique;

    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            string input = value.ToLower();
            if (input == "crispy" || input == "chewy" || input == "homemade")
            {
                this.bakingTechnique = value;
            }
            else throw new ArgumentException("Invalid type of dough.");
        }
    }

    private double weight;

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value >= 1 && value <= 200) this.weight = value;
            else throw new ArgumentException("Dough weight should be in the range [1..200].");
        }
    }

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        FlourType = flourType;
        BakingTechnique = bakingTechnique;
        Weight = weight;
    }

    public double TotalCalories()
    {
        double flourMultiplier = 0;
        double bakingMultiplier = 0;

        switch (BakingTechnique.ToLower())
        {
            case "crispy":
                bakingMultiplier = 0.9;
                break;
            case "chewy":
                bakingMultiplier = 1.1;
                break;
            case "homemade":
                bakingMultiplier = 1.0;
                break;
        }
        switch (FlourType.ToLower())
        {
            case "white":
                flourMultiplier = 1.5;
                break;
            case "wholegrain":
                flourMultiplier = 1.0;
                break;
        }
        return 2 * Weight * flourMultiplier * bakingMultiplier;
    }
}