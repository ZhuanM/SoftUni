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
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine($"Yes\nSum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}