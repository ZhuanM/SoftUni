using System;
using System.Collections.Generic;
using System.Text;


public abstract class Model
{
    public string Id { get; private set; }

    protected Model(string id) // It's protected because the derived classes should be able to chain the constructor (and it's not public because it's not going to be initialized)
    {
        this.Id = id;
    }
}