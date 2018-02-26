using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Child : Person
{
    private const int MIN_CHILD_AGE = 15;

    public Child(string name, int age) 
        : base(name, age)
    {       
    }

    public override int Age
    {
        get { return base.Age; }
        set
        {
            if (value > 15)
            {
                throw new ArgumentException($"Child's age must be less than {MIN_CHILD_AGE}!");
            }
            base.Age = value;
        }
    }
}