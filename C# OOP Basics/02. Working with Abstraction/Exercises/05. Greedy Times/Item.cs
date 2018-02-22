using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Item
{
    public string Key { get; protected set; }
    public long Value { get; protected set; }

    public void IncreaseValue(long value)
    {
        Value += value;
    }
}