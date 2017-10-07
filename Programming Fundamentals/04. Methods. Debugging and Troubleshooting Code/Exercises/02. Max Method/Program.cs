using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            int maxValue = Math.Max(a, b);
            return maxValue;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maxValue = GetMax(a, b);

            if (maxValue > c)
            {
                Console.WriteLine(maxValue);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}