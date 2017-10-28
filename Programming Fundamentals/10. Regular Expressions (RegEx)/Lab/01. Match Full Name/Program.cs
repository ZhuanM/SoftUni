﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";          

            foreach (Match name in Regex.Matches(input, pattern))
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}