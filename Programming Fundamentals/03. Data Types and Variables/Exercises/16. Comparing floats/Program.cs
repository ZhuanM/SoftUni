using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equalOrNot = new bool();

            if (a > b)
            {
                double difference = a - b;               
                if (difference < eps)
                {
                    equalOrNot = true;
                }
                else
                {
                    equalOrNot = false;
                }
            }
            else
            {
                double difference = b - a;
                if (difference < eps)
                {
                    equalOrNot = true;
                }
                else
                {
                    equalOrNot = false;
                }
            }
            Console.WriteLine(equalOrNot);
        }
    }
}