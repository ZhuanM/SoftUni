﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = new string(input.Reverse().ToArray());

            Console.WriteLine(reversed);
        }
    }
}