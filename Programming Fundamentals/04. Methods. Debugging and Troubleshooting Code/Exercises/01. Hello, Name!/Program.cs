﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class Program
    {
        static string HelloMethod(string name)
        {
            name = $"Hello, {name}!";
            return name;
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine(HelloMethod(name));
        }
    }
}