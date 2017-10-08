using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = AreaOfTriangle(side, height);

                Console.WriteLine($"{area:f2}");
            }

            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = AreaOfSquare(side);

                Console.WriteLine($"{area:f2}");
            }

            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = AreaOfRectangle(width, height);

                Console.WriteLine($"{area:f2}");
            }

            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = AreaOfCircle(radius);

                Console.WriteLine($"{area:f2}");
            }
        }

        static double AreaOfTriangle(double side, double height)
        {
            double area = (side * height) / 2;

            return area;
        }

        static double AreaOfSquare(double side)
        {
            double area = side * side;

            return area;
        }

        static double AreaOfRectangle(double width, double height)
        {
            double area = width * height;

            return area;
        }

        static double AreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;

            return area;
        }
    }
}