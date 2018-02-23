using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Validator
{
    public static void ValidateMoney(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentException("Money cannot be negative.");
        }
    }

    public static void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be empty.");
        }
    }
}