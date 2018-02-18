using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Siamese : Cat
{
    private string name;
    private int earSize;

    public Siamese(string name, int earSize)
        : base(name)
    {
        this.earSize = earSize;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} {base.Name} {earSize}";
    }
}