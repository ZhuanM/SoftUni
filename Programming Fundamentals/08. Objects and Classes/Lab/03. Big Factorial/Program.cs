﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));
        }

        static BigInteger Factorial(int n)
        {
            if (n >= 2) return n * Factorial(n - 1);
            return 1;
        }
    }
}