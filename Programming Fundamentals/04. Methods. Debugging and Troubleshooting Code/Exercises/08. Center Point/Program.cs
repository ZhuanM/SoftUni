﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, y1, x2, y2);
        }

        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double pos1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double pos2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (pos1 > pos2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}