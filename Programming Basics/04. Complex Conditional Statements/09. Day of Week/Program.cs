﻿using System;
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
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (n == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (n == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (n == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (n == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (n == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (n == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
