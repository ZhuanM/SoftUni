﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            string temp = array[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = temp;

            Console.WriteLine(string.Join(" ", array));
        }
    }
}