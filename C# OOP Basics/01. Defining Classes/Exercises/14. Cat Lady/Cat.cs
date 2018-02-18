using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat
{
    private string name;

    public Cat(string name)
    {
        this.name = name;
    }

    public string Name
    {
        get { return this.name; }
    }
}