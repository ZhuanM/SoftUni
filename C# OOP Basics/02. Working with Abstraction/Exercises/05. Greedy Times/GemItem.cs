using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GemItem : Item
{
    public GemItem(string key, long value)
    {
        Key = key;
        Value = value;
    }
}