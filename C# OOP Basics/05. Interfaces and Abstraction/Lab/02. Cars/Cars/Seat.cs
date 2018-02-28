using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Seat : Car, ICar
{
    public Seat(string model, string color) : base(model, color)
    {
    }
}