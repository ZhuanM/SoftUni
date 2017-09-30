using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int quant = int.Parse(Console.ReadLine());

            double price = 0;

            if (text == "Athlete")
            {
                price = quant * .7;
                Console.WriteLine($"The Athlete has to pay {price:f2}.");
            }
            else if (text == "Businessman" || text == "Businesswoman")
            {
                price = quant * 1;
                Console.WriteLine($"The {text} has to pay {price:f2}.");
            }
            else if (text == "SoftUni Student")
            {
                price = quant * 1.7;
                Console.WriteLine($"The {text} has to pay {price:f2}.");
            }
            else
            {
                price = quant * 1.2;
                Console.WriteLine($"The {text} has to pay {price:f2}.");
            }
        }
    }
}