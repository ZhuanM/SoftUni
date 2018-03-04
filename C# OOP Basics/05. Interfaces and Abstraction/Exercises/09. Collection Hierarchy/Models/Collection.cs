using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Collection : IAdd
{
    private List<string> list;

    protected IList<string> List
    {
        get => this.list;
    }

    public Collection()
    {
        this.list = new List<string>();
    }

    public abstract int Add(string element);
}