﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Patient
{
    public Patient(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
}