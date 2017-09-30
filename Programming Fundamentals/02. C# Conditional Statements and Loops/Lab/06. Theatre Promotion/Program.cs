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
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (0 <= age && age <= 18)
            {
                if (day == "weekday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "weekend")
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "holiday")
                {
                    price = 5;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (18 < age && age <= 64)
            {
                if (day == "weekday")
                {
                    price = 18;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "weekend")
                {
                    price = 20;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "holiday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
            }
            else if (64 < age && age <= 122)
            {
                if (day == "weekday")
                {
                    price = 12;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "weekend")
                {
                    price = 15;
                    Console.WriteLine($"{price}$");
                }
                else if (day == "holiday")
                {
                    price = 10;
                    Console.WriteLine($"{price}$");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}