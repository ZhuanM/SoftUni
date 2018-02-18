using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        PriceCalculator priceCalculator = new PriceCalculator(command);
        string totalPrice = priceCalculator.CalculatePrice();

        Console.WriteLine(totalPrice);
    }
}