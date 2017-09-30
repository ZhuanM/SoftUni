using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int curr = int.Parse(Console.ReadLine());
                sum += curr;
                max = Math.Max(max, curr);
            }

            if (max == sum - max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(max - (sum - max))}");
            }
        }
    }
}