using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string prod = Console.ReadLine();
            string city = Console.ReadLine();
            double quant = double.Parse(Console.ReadLine());
            prod = prod.ToLower();
            city = city.ToLower();

            if (city == "sofia")
            {
                if (prod == "coffee")
                {
                    double result = quant * .5;
                    Console.WriteLine(result);
                }
                else if (prod == "water")
                {
                    double result = quant * .8;
                    Console.WriteLine(result);
                }
                else if (prod == "beer")
                {
                    double result = quant * 1.2;
                    Console.WriteLine(result);
                }
                else if (prod == "sweets")
                {
                    double result = quant * 1.45;
                    Console.WriteLine(result);
                }
                else if (prod == "peanuts")
                {
                    double result = quant * 1.6;
                    Console.WriteLine(result);
                }
            }
            else if (city == "plovdiv")
            {
                if (prod == "coffee")
                {
                    double result = quant * .4;
                    Console.WriteLine(result);
                }
                else if (prod == "water")
                {
                    double result = quant * .7;
                    Console.WriteLine(result);
                }
                else if (prod == "beer")
                {
                    double result = quant * 1.15;
                    Console.WriteLine(result);
                }
                else if (prod == "sweets")
                {
                    double result = quant * 1.3;
                    Console.WriteLine(result);
                }
                else if (prod == "peanuts")
                {
                    double result = quant * 1.5;
                    Console.WriteLine(result);
                }
            }
            else if (city == "varna")
            {
                if (prod == "coffee")
                {
                    double result = quant * .45;
                    Console.WriteLine(result);
                }
                else if (prod == "water")
                {
                    double result = quant * .7;
                    Console.WriteLine(result);
                }
                else if (prod == "beer")
                {
                    double result = quant * 1.1;
                    Console.WriteLine(result);
                }
                else if (prod == "sweets")
                {
                    double result = quant * 1.35;
                    Console.WriteLine(result);
                }
                else if (prod == "peanuts")
                {
                    double result = quant * 1.55;
                    Console.WriteLine(result);
                }
            }
        }
    }
}