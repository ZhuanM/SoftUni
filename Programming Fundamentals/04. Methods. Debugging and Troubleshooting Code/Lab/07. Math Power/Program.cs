using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Math_Power
{
    class Program
    {
        static double MathPower(double num, double pow)
        {
            double poweredNumber = Math.Pow(num, pow);
            return poweredNumber;
        }

        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double poweredNumber = MathPower(num, pow);

            Console.WriteLine(poweredNumber);
        }
    }
}