using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = PointReader(Console.ReadLine());
            Point point2 = PointReader(Console.ReadLine());

            Console.WriteLine($"{CalcDistance(point1, point2):f3}");
        }

        static Point PointReader(string input)
        {
            int[] coordinates = input.Split(' ').Select(int.Parse).ToArray();
            return new Point() { X = coordinates[0], Y = coordinates[1]};
        }

        static double CalcDistance(Point p1, Point p2)
        {
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}