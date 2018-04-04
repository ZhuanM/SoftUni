﻿using System;
using System.Collections.Generic;
using System.Text;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Field, AllowMultiple = true)]
public class SoftUniAttribute : Attribute
{
    public string Name { get; private set; }

    public SoftUniAttribute(string name)
    {
        this.Name = name;
    }
}