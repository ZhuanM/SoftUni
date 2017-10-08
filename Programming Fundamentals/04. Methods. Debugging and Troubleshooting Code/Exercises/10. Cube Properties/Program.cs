using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string whatToCalculate = Console.ReadLine().ToLower();

            if (whatToCalculate == "face")
            {
                double face = CalculateFace(number);
                Console.WriteLine($"{face:f2}");
            }
            else if (whatToCalculate == "space")
            {
                double space = CalculateSpace(number);
                Console.WriteLine($"{space:f2}");
            }
            else if (whatToCalculate == "volume")
            {
                double volume = CalculateVolume(number);
                Console.WriteLine($"{volume:f2}");
            }
            else if (whatToCalculate == "area")
            {
                double area = CalculateArea(number);
                Console.WriteLine($"{area:f2}");
            }
        }

        static double CalculateFace(double num)
        {
            double face = Math.Sqrt(2 * Math.Pow(num, 2));

            return face;
        }

        static double CalculateSpace(double num)
        {
            double space = Math.Sqrt(3 * Math.Pow(num, 2)); ;

            return space;
        }

        static double CalculateVolume(double num)
        {
            double volume = Math.Pow(num, 3);

            return volume;
        }

        static double CalculateArea(double num)
        {
            double area = 6 * Math.Pow(num, 2);

            return area;
        }
    }
}