using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IIdentifiable, IName, IBirthable, IBuyer
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Id { get; set; }

    public DateTime Birthdate { get; set; }

    public int Food { get; set; }

    public void BuyFood()
    {
        this.Food += 10;
    }

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
    }
}