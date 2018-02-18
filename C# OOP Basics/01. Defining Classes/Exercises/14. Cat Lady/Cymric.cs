using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cymric : Cat
{
    private string name;
    private double furLength;

    public Cymric(string name, double furLength)
        : base(name)
    {
        this.furLength = furLength;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} {base.Name} {furLength:F2}";
    }
}