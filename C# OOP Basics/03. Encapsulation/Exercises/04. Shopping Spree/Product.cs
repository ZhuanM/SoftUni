using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Product
{
    private string name;
    private decimal price;

    public string Name
    {
        get { return this.name; }
        set
        {
            Validator.ValidateName(value);
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            Validator.ValidateMoney(value);
            this.price = value;
        }
    }
}