﻿using System;
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
            int n = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (n > 1000)
            {
                bonus += n * 0.1;
            }
            else if (n > 100)
            {
                bonus += n * 0.2;
            }
            else if (n <= 100)
            {
                bonus += 5;
            }
            if (n % 2 == 0)
            {
                bonus += 1;
            }
            else if (n % 10 == 5)
            {
                bonus += 2;
            }
            var withBonus = bonus + n;
            Console.WriteLine(bonus);
            Console.WriteLine(withBonus);
        }
    }
}
