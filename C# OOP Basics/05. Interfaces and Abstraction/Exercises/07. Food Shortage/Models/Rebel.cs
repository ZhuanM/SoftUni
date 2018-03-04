using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rebel : IName, IBuyer
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Group { get; set; }

    public int Food { get; set; }

    public void BuyFood()
    {
        this.Food += 5;
    }

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }
}