using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PriceCalculator
{
    private decimal pricePerNight;
    private int nights;
    private Seasons season;
    private Discounts discount;

    public PriceCalculator(string command)
    {
        var splitCommand = command.Split();

        pricePerNight = decimal.Parse(splitCommand[0]);
        nights = int.Parse(splitCommand[1]);
       // season = Enum.Parse(Seasons, splitCommand[2]); DOESN'T WORK
        discount = Discounts.None;

        if (splitCommand.Length > 3)
        {
           // discount = Enum.Parse(Discounts, splitCommand[3]); DOESN'T WORK
        }
    }

    public string CalculatePrice()
    {
        decimal tempTotal = pricePerNight * nights * (int)season;
        decimal discountPercentage = ((decimal)100 - (int)discount) / 100;
        decimal totalPrice = tempTotal * discountPercentage;

        return totalPrice.ToString("F2");
    }
}