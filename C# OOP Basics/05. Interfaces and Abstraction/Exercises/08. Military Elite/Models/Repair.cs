using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Repair : IRepair
{
    public Repair(string partName, int hours)
    {
        this.Part = partName;
        this.Hours = hours;
    }

    public string Part { get; set; }

    public int Hours { get; set; }

    public override string ToString()
    {
        return $"  Part Name: {Part} Hours Worked: {Hours}";
    }
}