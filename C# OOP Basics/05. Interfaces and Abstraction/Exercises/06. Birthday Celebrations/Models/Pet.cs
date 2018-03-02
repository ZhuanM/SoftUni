using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pet : IName, IBirthable
{
    public string Name { get; set; }

    public DateTime Birthdate { get; set; }

    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
    }
}