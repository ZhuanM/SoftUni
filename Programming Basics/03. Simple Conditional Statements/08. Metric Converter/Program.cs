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
            double num = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double In = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            from = from.ToLower();
            to = to.ToLower();

            if (from == "mm")
            {
                num /= mm;
            }
            else if (from == "cm")
            {
                num /= cm;
            }
            else if (from == "m")
            {
                num /= 1;
            }
            else if (from == "mi")
            {
                num /= mi;
            }
            else if (from == "in")
            {
                num /= In;
            }
            else if (from == "km")
            {
                num /= km;
            }
            else if (from == "ft")
            {
                num /= ft;
            }
            else if (from == "yd")
            {
                num /= yd;
            }

            if (to == "mm")
            {
                num *= mm;
            }
            else if (to == "cm")
            {
                num *= cm;
            }
            else if (to == "m")
            {
                num *= 1;
            }
            else if (to == "mi")
            {
                num *= mi;
            }
            else if (to == "in")
            {
                num *= In;
            }
            else if (to == "km")
            {
                num *= km;
            }
            else if (to == "ft")
            {
                num *= ft;
            }
            else if (to == "yd")
            {
                num *= yd;
            }
            Console.WriteLine($"{num:f8}");
        }
    }
}