using System;
using System.Collections.Generic;
using System.Text;


public abstract class Model
{
    public string Id { get; private set; }

    protected Model(string id)
    {
        this.Id = id;
    }
}