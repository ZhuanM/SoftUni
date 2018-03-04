using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddCollection : Collection
{
    public AddCollection()
        : base()
    { }

    public override int Add(string element)
    {
        this.List.Add(element);

        return this.List.Count - 1;
    }
}