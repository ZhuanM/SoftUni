using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Point point = PointReader(Console.ReadLine());
                points[i] = point;
            }

            Point[] closestPoints = FindClosestPoints(points);
            foreach (Point point in closestPoints)
            {
                Console.WriteLine("({0}, {1})", point.X, point.Y);
            }
        }

        static Point PointReader(string input)
        {
            int[] coordinates = input.Split(' ').Select(int.Parse).ToArray();
            return new Point() { X = coordinates[0], Y = coordinates[1] };
        }

        static Point[] FindClosestPoints(Point[] points)
        {
            Point[] closestPoints = new Point[2];
            double minimalDistance = double.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    if (CalcDistance(points[i], points[j]) < minimalDistance)
                    {
                        minimalDistance = CalcDistance(points[i], points[j]);
                        closestPoints[0] = points[i];
                        closestPoints[1] = points[j];
                    }
                }
            }

            Console.WriteLine("{0:F3}", minimalDistance);
            return closestPoints;
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