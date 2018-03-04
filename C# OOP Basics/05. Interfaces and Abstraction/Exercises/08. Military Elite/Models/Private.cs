﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Private : Soldier, IPrivate
{
    public Private(string id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public decimal Salary { get; private set; }

    public override string ToString()
    {
        return $"{base.ToString()} Salary: {Salary:f2}";
    }
}