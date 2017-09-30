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
            string type = Console.ReadLine();
            type = type.ToLower();

            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double result = a * a;
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double result = a * b;
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (type == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double result = Math.PI * a * a;
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double result = (a * b) / 2;
                Console.WriteLine(Math.Round(result, 3));
            }
        }
    }
}
