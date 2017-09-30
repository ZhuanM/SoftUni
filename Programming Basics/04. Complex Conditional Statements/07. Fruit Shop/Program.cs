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
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double quant = double.Parse(Console.ReadLine());

            if (day == "monday" ||
                day == "tuesday" ||
                day == "wednesday" ||
                day == "thursday" ||
                day == "friday")
            {
                if (fruit == "banana")
                {
                    double result = quant * 2.5;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "apple")
                {
                    double result = quant * 1.2;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "orange")
                {
                    double result = quant * .85;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "grapefruit")
                {
                    double result = quant * 1.45;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "kiwi")
                {
                    double result = quant * 2.7;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "pineapple")
                {
                    double result = quant * 5.5;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "grapes")
                {
                    double result = quant * 3.85;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (day == "saturday" || day == "sunday")
            {
                if (fruit == "banana")
                {
                    double result = quant * 2.7;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "apple")
                {
                    double result = quant * 1.25;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "orange")
                {
                    double result = quant * .9;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "grapefruit")
                {
                    double result = quant * 1.6;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "kiwi")
                {
                    double result = quant * 3;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "pineapple")
                {
                    double result = quant * 5.6;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else if (fruit == "grapes")
                {
                    double result = quant * 4.2;
                    Console.WriteLine(Math.Round(result, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}