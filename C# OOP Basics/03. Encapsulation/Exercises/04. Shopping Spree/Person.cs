using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.Products = new List<Product>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            Validator.ValidateName(value);
            this.name = value;
        }
    }

    public decimal Money
    {
        get { return this.money; }
        private set
        {
            Validator.ValidateMoney(value);
            this.money = value;
        }
    }

    public List<Product> Products
    {
        get { return this.products; }
        private set { ; }
    }
}